using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CloudFormationCs.Resources.DynamoDB;
using System.IO;

namespace CloudFormationCs
{
    /// <summary>
    /// Scraps AWS online documentation and creates C# classes
    /// </summary>
    /// <remarks>
    /// Use https://roslynquoter.azurewebsites.net/ and add "SyntaxFactory." to fix errors. For example:
    /// 
    ///     ArrayType(
    ///         IdentifierName("Foo"))
    /// 
    /// becomes
    /// 
    ///     SyntaxFactory.ArrayType(
    ///         SyntaxFactory.IdentifierName("Foo"))
    /// </remarks>
    public static class CodeGen
    {
        public static void Run(string basePath)
        {
            DownloadRecursive(0, basePath, "WAFv2", "WebACL", "https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafv2-webacl.html");

            Console.WriteLine("Lines of code: " + totalCodeLines);
        }
        private static List<string> processedTypes = new List<string>();
        private static int totalCodeLines = 0;
        private static void DownloadRecursive(int level, string basePath, string serviceName, string className, string url)
        {
            Console.WriteLine(url);

            var web = new HtmlWeb();
            var doc = web.Load(url);

            var code = doc.DocumentNode.SelectNodes(".//code").FirstOrDefault(r => r.HasClass("json"));
            if (code == null)
            {
                Console.WriteLine("Node not found");
            }
            else
            {
                var baseUrl = url.Split('/');
                //var links = new Dictionary<string, string>();
                foreach (var node in code.ChildNodes)
                {
                    if (node.Name == "code")
                    {
                        foreach (var line in node.ChildNodes)
                        {
                            if (line.Name == "a")
                            {
                                var href = line.Attributes["href"].Value;
                                if (!href.StartsWith("#") && line.InnerText != "Tag")
                                {
                                    if (!processedTypes.Contains(line.InnerText))
                                    {
                                        //Console.WriteLine(line.InnerText.PadRight(20) + " " + href);
                                        if (href.StartsWith("./"))
                                        {
                                            baseUrl[baseUrl.Length - 1] = href.Substring(2);
                                            href = string.Join("/", baseUrl);
                                        }
                                        DownloadRecursive(level + 1, basePath, serviceName, line.InnerText, href);

                                        processedTypes.Add(line.InnerText);
                                    }
                                }
                            }
                        }
                    }
                }
                var json = FixFormat(code.InnerText, level == 0 ? 3 : 1);

                Console.WriteLine(json);
                Dictionary<string, string> properties;

                if (level == 0)
                {
                    properties = JsonConvert.DeserializeObject<Definition>(json).Properties;
                }
                else
                {
                    properties = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                }
                var @namespace = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.ParseName("CloudFormationCs.Resources." + serviceName)).NormalizeWhitespace();

                @namespace = @namespace.AddUsings(
                        SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System"))
                        //SyntaxFactory.UsingDirective(SyntaxFactory.ParseName("System.Runtime.Serialization"))
                    );

                var tableFieldNameClass = SyntaxFactory.ClassDeclaration(className)
                    .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword));


                DocumentationCommentTriviaSyntax documentationComment = SyntaxFactory.DocumentationComment(
                     SyntaxFactory.XmlSummaryElement(
                         SyntaxFactory.XmlNewLine(Environment.NewLine),
                         SyntaxFactory.XmlText(" "+ url),
                         SyntaxFactory.XmlNewLine(Environment.NewLine)));

                tableFieldNameClass = tableFieldNameClass
                    .WithLeadingTrivia(
                        SyntaxFactory.Trivia(documentationComment));

                if (level == 0)
                {
                    tableFieldNameClass = tableFieldNameClass.AddBaseListTypes(
                        SyntaxFactory.SimpleBaseType(SyntaxFactory.ParseTypeName("Resource"))
                    );
                }

                foreach (var prop in properties)
                {
                    //Console.WriteLine(prop.Key.PadRight(20) + prop.Value);

                    string type = prop.Value;
                    var isArray = type.StartsWith("[");
                    if (isArray)
                    {
                        type = type.Substring(2).Split(',')[0].Trim();
                    }
                    switch (type)
                    {
                        case "String":
                            type += "Ref";
                            break;

                        case "Json":
                            type = "object";
                            break;

                        case "Integer":
                            type = "int";
                            break;
                    }
                    TypeSyntax typeSyntax = SyntaxFactory.ParseTypeName(type);
                    if (type == "Boolean")
                    {
                        typeSyntax = SyntaxFactory.NullableType(typeSyntax);
                    }
                    if (isArray)
                    {
                        typeSyntax = SyntaxFactory.ArrayType(typeSyntax)
                            .WithRankSpecifiers(
                        SyntaxFactory.SingletonList<ArrayRankSpecifierSyntax>(
                            SyntaxFactory.ArrayRankSpecifier(
                                SyntaxFactory.SingletonSeparatedList<ExpressionSyntax>(
                                    SyntaxFactory.OmittedArraySizeExpression()))))
                            ;
                    }
                    var propertyDeclaration = SyntaxFactory.PropertyDeclaration(typeSyntax, prop.Key)
                        .AddModifiers(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                        .AddAccessorListAccessors(
                            SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                            SyntaxFactory
                                .AccessorDeclaration(SyntaxKind.SetAccessorDeclaration)
                                .WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)));

                    tableFieldNameClass = tableFieldNameClass.AddMembers(propertyDeclaration);
                }
                if (level == 0)
                {
                    tableFieldNameClass = tableFieldNameClass.AddMembers(
                        SyntaxFactory.ConstructorDeclaration(
                            SyntaxFactory.Identifier(className))
                        .WithModifiers(
                            SyntaxFactory.TokenList(
                                SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                        .WithInitializer(
                            SyntaxFactory.ConstructorInitializer(
                                SyntaxKind.BaseConstructorInitializer,
                                SyntaxFactory.ArgumentList()))
                        .WithBody(
                            SyntaxFactory.Block()),
                        SyntaxFactory.ConstructorDeclaration(
                            SyntaxFactory.Identifier(className))
                        .WithModifiers(
                            SyntaxFactory.TokenList(
                                SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                        .WithParameterList(
                            SyntaxFactory.ParameterList(
                                SyntaxFactory.SingletonSeparatedList<ParameterSyntax>(
                                    SyntaxFactory.Parameter(
                                        SyntaxFactory.Identifier("resourceIdentifier"))
                                    .WithType(
                                        SyntaxFactory.IdentifierName("StringOrEnum")))))
                        .WithInitializer(
                            SyntaxFactory.ConstructorInitializer(
                                SyntaxKind.BaseConstructorInitializer,
                                SyntaxFactory.ArgumentList(
                                    SyntaxFactory.SingletonSeparatedList<ArgumentSyntax>(
                                        SyntaxFactory.Argument(
                                            SyntaxFactory.IdentifierName("resourceIdentifier"))))))
                            .WithBody(
                                SyntaxFactory.Block())
                        );
                }

                @namespace = @namespace.AddMembers(tableFieldNameClass);

                var codeout = @namespace.NormalizeWhitespace().ToFullString().Replace("/summary>", "/summary>" + Environment.NewLine + "    ");

                if (Environment.NewLine.Length == 2)
                {
                    totalCodeLines += codeout.Replace(Environment.NewLine[0].ToString(), "").Split(Environment.NewLine[1]).Length;
                }
                if (true)
                {
                    var outputPath = Path.Combine(basePath, serviceName, className + ".cs");
                    Console.WriteLine("Writing :" + outputPath);
                    File.WriteAllText(outputPath, codeout);
                }
                else
                {
                    Console.WriteLine(codeout);
                }
            }
        }
        private static string FixFormat(string json, int startLine)
        {
            var lines = json.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = startLine; i < lines.Length; i++)
            {
                string l = lines[i];
                if (l.Contains("}"))
                {
                    break;
                }
                l = l.Replace(" : ", " : \"");
                if (l.EndsWith(","))
                {
                    l = l.Substring(0, l.Length - 1) + "\",";
                }
                else
                {
                    l += "\"";
                }
                lines[i] = l;
            }
            return string.Join(Environment.NewLine, lines);
        }
    }
    internal class Definition
    {
        public string Type { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }

}
