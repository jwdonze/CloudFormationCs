using System;

namespace CloudFormationCs
{
    public class Tag
    {
        public String Key { get; set; }

        public StringRef Value { get; set; }

        public Tag()
        {
        }

        public Tag(String key, StringRef val)
        {
            this.Key = key;
            this.Value = val;
        }
        public static Tag Name(StringRef name)
        {
            return new Tag(CommonValues.Name, name);
        }
        public static Tag[] NameAsArray(StringRef name)
        {
            return new Tag[] { Tag.Name(name), };
        }
        public static Tag Application(StringRef name)
        {
            return new Tag(CommonValues.Application, name);
        }
        public static Tag Network(StringRef name)
        {
            return new Tag(CommonValues.Network, name);
        }
        public static class CommonValues
        {
            /// <summary>
            /// aws:cloudformation:stack-name
            /// </summary>
            public const string aws_cloudformation_stack_name = "aws:cloudformation:stack-name";
            /// <summary>
            /// Name
            /// </summary>
            public const string Name = "Name";
            public const string Application = "Application";
            public const string Network = "Network";
        }
    }
}

