using System.Security.Cryptography;
using System.Text;

namespace Section10_Ex12 {
    internal class Program {
        static void Main(string[] args) {
            string caminhoCriptografar = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Backup\poetaFernando.txt";
            string caminhoCriptografarDestino = @"C:\ws-c#\Section10Solution\ExDiretorios\TesteArquivos\Backup\poetaFernandoCriptografado.txt";
            using StreamReader sr = new StreamReader(caminhoCriptografar);
            string conteudo = sr.ReadToEnd();
            string chave = "minhachave123456";
            byte[] conteudoCriptografado;
            using (Aes aes = Aes.Create()) {
                aes.Key = Encoding.UTF8.GetBytes(chave);
                aes.Mode = CipherMode.CBC;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream()) {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write)) {
                        using (StreamWriter sw = new StreamWriter(cs)) {
                            sw.Write(conteudo);
                        }
                        conteudoCriptografado = ms.ToArray();
                    }
                }
            }
            File.WriteAllBytes(caminhoCriptografarDestino, conteudoCriptografado);
            Console.WriteLine("Arquivo criptografado com sucesso!");
        }
    }
}
