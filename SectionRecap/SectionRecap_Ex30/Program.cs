using SectionRecap_Ex28;
using System.Xml.Serialization;

namespace SectionRecap_Ex30 {
    internal class Program {
        static void Main(string[] args) {
            Pessoa p = new Pessoa() { Nome = "Gustavo", Idade = 19 };

            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\pessoaXml.xml";
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            using (FileStream fs1 = new FileStream(caminho, FileMode.Create, FileAccess.Write)) {
                xml.Serialize(fs1, p);
            }

            using (FileStream fs2 = new FileStream(caminho, FileMode.Open, FileAccess.Read)) {
                Pessoa p2 = (Pessoa)xml.Deserialize(fs2)!;
                Console.WriteLine($"{p2.Nome} - {p2.Idade}");
            }
        }
    }
}
