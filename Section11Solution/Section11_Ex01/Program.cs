using System.Text.Json;
using System.Xml.Serialization;

namespace Section11_Ex01 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoJSON = @"C:\ws-c#\Section11Solution\Arquivos\SerializadosEx\listaAlunos.json";
            string caminhoXML = @"C:\ws-c#\Section11Solution\Arquivos\SerializadosEx\listaAlunos.xml";

            List<Aluno> listaAluno = new List<Aluno>() { 
                new Aluno(101, "Maria", "maria@yahoo.com", 18), 
                new Aluno(102, "Gustavo", "gustavo@yahoo.com", 28), 
                new Aluno(103, "José", "jose@yahoo.com", 36) 
            };

            using FileStream streamJSON = new FileStream(caminhoJSON, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            JsonSerializer.Serialize(streamJSON, listaAluno);
            Console.WriteLine("Arquivo JSON serializado com sucesso!");

            var xmlSerializer = new XmlSerializer(typeof(List<Aluno>));
            using (FileStream streamXML = new FileStream(caminhoXML, FileMode.Create, FileAccess.Write)) {
                xmlSerializer.Serialize(streamXML, listaAluno);
            }
            Console.WriteLine("Arquivo XML serializado com sucesso!");
        }
    }
}
