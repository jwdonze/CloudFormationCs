using System;

namespace CloudFormationCs
{
    public interface IAwsCustomFormatter
    {
        object FormatForAws(object input);
    }
}

