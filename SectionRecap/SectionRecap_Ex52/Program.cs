namespace SectionRecap_Ex52 {
    internal class Program {
        static void Main(string[] args) {
            List<Livro> listLivros = new() {
                new Livro("Dom Casmurro", "Machado de Assis", 1889),
                new Livro("Harry Potter e a Pedra Filosofal", "J.K.Rowling", 1999),
                new Livro("Oo Pequeno Príncipe", "Chelq Tchovik", 1978)
            };

            string caminho = @"C:\ws-c#\SectionRecap\Arquivos\livros.txt";

            foreach (var livro in listLivros) {
                Console.WriteLine(livro.ToString());
                File.WriteAllText(caminho, "\r\n" + livro.ToString());
            }
            
        }
    }
}
