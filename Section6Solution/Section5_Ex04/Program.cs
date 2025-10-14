namespace Section5_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("\nÁlbum padrão: ");
            LivroFotos albumPadrao = new LivroFotos();
            Console.WriteLine($"Número de páginas: {albumPadrao.GetNumeroPaginas()}");

            Console.WriteLine("\nÁlbum Customizado: ");
            LivroFotos albumCustomizado = new LivroFotos(24);
            Console.WriteLine($"Número de páginas: {albumCustomizado.GetNumeroPaginas()}");

            Console.WriteLine("\nSuper Álbum: ");
            LivroFotos superAlbum = new SuperLivroFotos();
            Console.WriteLine($"Número de páginas: {superAlbum.GetNumeroPaginas()}");
            
        }
    }
}
