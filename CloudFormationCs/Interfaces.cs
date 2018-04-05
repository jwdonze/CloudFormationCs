using System;

using Newtonsoft.Json;

namespace CloudFormationCs
{
    public interface IKeyValue
    {
        String Key { get; }

        Object Value { get; }
    }
    public interface IKeyx
    {
        String Key { get; }
    }
    public interface IWriteObject
    {
        void WriteTo(JsonWriter writer, JsonSerializer serializer);
    }
}

