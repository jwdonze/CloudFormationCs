using System;
using System.Collections.Generic;

namespace CloudFormationCs.Resources.CloudFormation
{
    public class fileSpec
    {
        public string path { get; set; }
        public file file { get; set; }
        public fileSpec(string path, file file)
        {
            this.path = path;
            this.file = file;
        }
    }
    public class fileCollection : Dictionary<String, file>
    {
        public fileCollection() : base() { }

        public fileCollection Add(fileSpec file)
        {
            this.Add(file.path, file.file);
            return this;
        }
        public static fileCollection FromArray(fileSpec[] files)
        {
            var fc = new fileCollection();
            foreach (var file in files)
            {
                fc.Add(file.path, file.file);
            }
            return fc;
        }
    }
    public class file
    {
        public String source { get; set; }

        public StringRef content { get; set; }

        public String mode { get; set; }

        public String owner { get; set; }

        public String group { get; set; }

        public static file root644(StringRef content)
        {
            return new file()
            {
                content = content,
                mode = "000644",
                owner = "root",
                group = "root",
            };
        }
        public static file root700(StringRef content)
        {
            return new file()
            {
                content = content,
                mode = "000700",
                owner = "root",
                group = "root",
            };
        }
        public static file root755(StringRef content)
        {
            return new file()
            {
                content = content,
                mode = "000755",
                owner = "root",
                group = "root",
            };
        }
    }
}
