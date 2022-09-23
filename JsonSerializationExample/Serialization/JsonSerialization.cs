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
    }
}
