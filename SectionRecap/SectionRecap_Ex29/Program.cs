using SectionRecap_Ex28;
using System.Text.Json;

namespace SectionRecap_Ex29 {
    internal class Program {
        static void Main(string[] args) {
            List<Pessoa> pessoas = new List<Pessoa>() {
                new Pessoa { Nome = "Ana", Idade = 25 },
                new Pessoa { Nome = "Leo", Idade = 36 },
                new Pessoa { Nome = "Rodrigo", Idade = 46 }
            };

            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\listaPessoa.json";
            string json = JsonSerializer.Serialize(pessoas);
            File.WriteAllText(caminho, json);

            var result = File.ReadAllText(caminho);
            List<Pessoa> pessoas2 = JsonSerializer.Deserialize<List<Pessoa>>(result);

            foreach (var pessoa in pessoas2)
                Console.WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade}");
        }
    }
}
