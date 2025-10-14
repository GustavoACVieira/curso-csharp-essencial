namespace SectionRecap_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Repositorio<string> repositorioString = new Repositorio<string>();
            Repositorio<Produto> repositorioProd = new Repositorio<Produto>();

            Console.WriteLine("Rep Strings: \n");
            repositorioString.Adicionar("Gustavo");
            repositorioString.Adicionar("Kaio");
            repositorioString.Adicionar("Jorge");
            repositorioString.Adicionar("Marcos");

            repositorioString.Listar();

            Console.WriteLine("\nRep Produto: \n");
            repositorioProd.Adicionar(new Produto(101, "Cadeira", 599.90));
            repositorioProd.Adicionar(new Produto(102, "Mesa", 1321.45));
            repositorioProd.Adicionar(new Produto(103, "Abajur", 59.90));

            repositorioProd.Listar();
        }
    }
}
