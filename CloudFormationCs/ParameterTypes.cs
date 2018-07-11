using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace CloudFormationCs
{
    public enum ParameterTypes
    {
        Undefined = 0,
        String,
        [EnumMember(Value ="AWS::SSM::Parameter::Value<AWS::EC2::Image::Id>")]
        ImageId,
    }
}

