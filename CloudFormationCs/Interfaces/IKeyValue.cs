using System;

namespace CloudFormationCs
{
    public interface IKeyValue
    {
        String Key { get; }

        Object Value { get; }
    }
}

