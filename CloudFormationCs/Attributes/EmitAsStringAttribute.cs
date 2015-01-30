using System;

namespace CloudFormationCs
{
    /// <summary>
    /// Serialize the property as a string regardless of type (typically Boolean and Integer types)
    /// </summary>
    public class EmitAsStringAttribute : System.Attribute
    {

        private IAwsCustomFormatter _awsCustomFormatter;
        public EmitAsStringAttribute() : base() { }
        public EmitAsStringAttribute(Type customFormatterType)
        {
            this._awsCustomFormatter = Activator.CreateInstance(customFormatterType) as IAwsCustomFormatter;
        }

        public Object FormatForAws(Object input)
        {
            if (this._awsCustomFormatter != null)
            {
                return this._awsCustomFormatter.FormatForAws(input);
            }
            else
            {
                return input.ToString();
            }
        }
    }
}

