using System;
using System.Text.Json;

namespace JsonSerializationExample.Serialization
{
    public class JsonSerialization
    {
        public static Pessoa Deserialize(string json)
        {
            return JsonSerializer.Deserialize<Pessoa>(json);
        }

        public static string Serialize(Pessoa pessoa)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            return JsonSerializer.Serialize(pessoa, options);
        }

        public static Pessoa DeserializeUtf8Bytes(byte[] jsonUtf8Bytes)
        {
            var readOnlySpan = new ReadOnlySpan<byte>(jsonUtf8Bytes);

            return JsonSerializer.Deserialize<Pessoa>(readOnlySpan)!;
        }

        public static byte[] SerializeUtf8(Pessoa pessoa)
        {
            return JsonSerializer.SerializeToUtf8Bytes(pessoa);
        }
    }
}
