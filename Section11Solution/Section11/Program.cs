using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Section11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com", 17);
            var caminho = @"C:\ws-c#\Section11Solution\Arquivos\Serializados\AlunoSerializado.json";

            //1
            //BinaryFormatter é obsoleto por ser inseguro
            //var caminho = @"C:\ws-c#\Section11Solution\Arquivos\Serializados\AlunoSerializado.bin";
            //using FileStream stream = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //var bf = new BinaryFormatter();
            //bf.Serialize(stream, aluno1);


            //2
            //Serialização XML ou SOAP
            //XmlSerializer serializer = new XmlSerializer(typeof(Aluno));
            //using (StreamWriter writer = new StreamWriter(caminho)) {
            //    serializer.Serialize(writer, aluno1);
            //}
            //Console.WriteLine("Objeto serializado para XML!");

            //Desserialização XML ou SOAP
            //using (StreamReader reader = new StreamReader(caminho)) {
            //    var aluno = (Aluno)serializer.Deserialize(reader);
            //    Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, Email: {aluno.Email}, Idade: {aluno.Idade}");
            //}


            //3
            //Serialização JSON
            //using FileStream stream = new FileStream(caminho, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //JsonSerializer.Serialize(stream, aluno1);
            //Console.WriteLine("Objeto serializado para JSON!");

            //Desserialização JSON
            //string jsonContent = File.ReadAllText(caminho);
            //var aluno = JsonSerializer.Deserialize<Aluno>(jsonContent);
            //Console.WriteLine($"Aluno XML desserializado - Id: {aluno.Id}, Nome: {aluno.Name}, Email: {aluno.Email}, Idade: {aluno.Idade}");
        }
    }
}
