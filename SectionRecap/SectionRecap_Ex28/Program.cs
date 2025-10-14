using System.Text.Json;

namespace SectionRecap_Ex28 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\pessoaJson.json";

            Pessoa p = new Pessoa() { Nome = "Gustavo", Idade = 19 };
            string json = JsonSerializer.Serialize(p);
            File.WriteAllText(caminho, json);

            var result = File.ReadAllText(caminho);
            Console.WriteLine(result);

            Pessoa p2 = JsonSerializer.Deserialize<Pessoa>(result);
        }
    }
}
