using JsonSerializationExample.Serialization;
using System;

namespace JsonSerializationExample
{
    class Program
    {
        static void Main()
        {
            var json = @"{""Nome"": ""Jonas Silva"", ""Idade"": 33}";
            
            var pessoa = JsonSerialization.Deserialize(json);
            var jsonNovo = JsonSerialization.Serialize(pessoa);

            var jsonBytes = JsonSerialization.SerializeUtf8(pessoa);
            var pessoaNova = JsonSerialization.DeserializeUtf8Bytes(jsonBytes);

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);

            Console.WriteLine(pessoaNova.Nome);
            Console.WriteLine(pessoaNova.Idade);

            Console.WriteLine(jsonNovo);

            JsonDocumentSerialization.Serialize();
            JsonDocumentSerialization.SerializeTelefones();
        }
    }
}
