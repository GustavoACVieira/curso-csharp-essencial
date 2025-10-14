namespace SectionRecap_Ex27 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\Certificado Gustavo C#.jpg";
            string caminhoDestino = @"C:\ws-c#\SectionRecap\Arquivos\Destino\CertificadoGustavo.jpg";

            byte[] buffer = new byte[1024];
            int bytesLidos;

            using FileStream destino = new FileStream(caminhoDestino, FileMode.OpenOrCreate, FileAccess.Write);
            using (FileStream fileStream = new FileStream(caminho, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite)) {
                while ((bytesLidos = fileStream.Read(buffer, 0, buffer.Length)) > 0) {
                    destino.Write(buffer, 0, bytesLidos);
                }
            }
        }
    }
}
