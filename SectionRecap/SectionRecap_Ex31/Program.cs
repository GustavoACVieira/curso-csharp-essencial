using System.Xml.Serialization;

namespace SectionRecap_Ex31 {
    internal class Program {
        static void Main(string[] args) {
            //Ex 4 Desserialização XML
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome = "Ana", Idade = 25 },
                new Pessoa { Nome = "Leo", Idade = 36 },
                new Pessoa { Nome = "Rodrigo", Idade = 46 }
            };

            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\listaPessoa.xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<Pessoa>));

            using (FileStream fs1 = new FileStream(caminho, FileMode.Create, FileAccess.Write)) {
                xml.Serialize(fs1, pessoas);
            }

            List<Pessoa> p2;
            using (FileStream fs2 = new FileStream(caminho, FileMode.Open, FileAccess.Read)) {
                p2 = (List<Pessoa>)xml.Deserialize(fs2)!;
            }

            foreach (var pessoa2 in p2) {
                Console.WriteLine($"{pessoa2.Nome} - {pessoa2.Idade}");
            }

        }
    }
}
