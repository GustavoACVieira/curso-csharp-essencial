namespace Section10_Ex08 {
    internal class Program {
        static void Main(string[] args) {
            string caminho = @"C:\ws-c#\Section10Solution\ArquivosTXT\";
            int opcao = 0;
            string arquivo = "";
            StreamReader sr = null;
            StreamWriter sw = null;
            string caminhoArquivo = "";

            try {
                do {
                    Console.WriteLine("## MENU ##");
                    Console.WriteLine("""
                    1- Criar arquivo
                    2- Gravar no arquivo
                    3- Ler arquivo
                    4- Procurar no arquivo
                    5- Sair
                    """);
                    opcao = int.Parse(Console.ReadLine());

                    switch (opcao) {
                        case 1:
                            Console.WriteLine("Informe o nome do arquivo que deseja criar e sua extensão: ");
                            arquivo = Console.ReadLine();
                            caminhoArquivo = caminho + arquivo;
                            File.Create(caminhoArquivo).Close();
                            Console.WriteLine("Arquivo Criado!");
                            break;
                        case 2:
                            sw = new StreamWriter(caminhoArquivo);
                            Console.WriteLine("Digite o conteudo que desja adicionar no arquivo: ");
                            sw.WriteLine(Console.ReadLine());
                            Console.WriteLine("Arquivo gravado!");
                            break;
                        case 3:
                            sr = File.OpenText(caminhoArquivo);
                            Console.WriteLine("\n## Conteúdo Arquvio ##");
                            Console.WriteLine(sr.ReadToEnd());
                            break;
                        case 4:
                            Console.WriteLine("Informe o que deseja procurar: ");
                            string search = Console.ReadLine();
                            string texto = sr.ReadToEnd();
                            if (texto.Contains(search))
                                Console.WriteLine("O arquivo contém esse texto!");
                            else
                                Console.WriteLine("O arquivo não cotém esse texto!");
                            break;
                        default:
                            break;
                    }
                } while (opcao != 5);
            } catch (IOException ex) {
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            } finally {
                if (sw != null) sw.Close();
                if (sr != null) sr.Close();
                Console.WriteLine("\nEncerrando....");
            }

        }
    }
}
