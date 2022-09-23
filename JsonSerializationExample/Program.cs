using JsonSerializationExample.Serialization;
using System;

namespace JsonSerializationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = @"{""Nome"": ""Jonas Silva"", ""Idade"": 33}";

            var pessoa = JsonSerialization.Deserialize(json);
            var jsonNovo = JsonSerialization.Serialize(pessoa);

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);

            Console.WriteLine(jsonNovo);
        }
    }
}
