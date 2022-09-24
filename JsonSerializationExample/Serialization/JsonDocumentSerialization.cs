using System;
using System.Linq;
using System.Text.Json;

namespace JsonSerializationExample.Serialization
{
    public class JsonDocumentSerialization
    {
        public static void Serialize()
        {
            var json = @"{""Nome"":""Carlos Silva"",""Idade"":33, ""Telefones"": { ""celular"": ""11-99999-9999"", ""comercial"": ""11-4444-4444""}}";
            var obj = JsonDocument.Parse(json);
            var nome = obj.RootElement.GetProperty("Nome").GetString();
            var celular = obj.RootElement.GetProperty("Telefones").GetProperty("celular").GetString();
            Console.WriteLine(nome);
            Console.WriteLine(celular);
        }

        public static void SerializeTelefones()
        {
            var json = @"{""Nome"":""Carlos Silva"",""Idade"":33, ""Telefones"": { ""celular"": ""11-99999-9999"", ""comercial"": ""11-4444-4444""}}";
            var obj = JsonDocument.Parse(json);

            var telefones = obj.RootElement.EnumerateObject()
                               .Where(jsonProperty => jsonProperty.Name.Contains("Telefones")
                                                     && jsonProperty.Value.ValueKind == JsonValueKind.Object)
                               .Select(jsonProperty => jsonProperty.Value.GetProperty("comercial"));

            foreach (var telefone in telefones) Console.WriteLine(telefone);
        }
    }
}
