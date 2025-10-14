using Section13_Ex01;

namespace Section13_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            var listaNumeros = FonteDeDados.GetNumeros();

            var listaNumeroAtt = listaNumeros.Select(x => x * 2).Where(x => x > 10).Distinct().OrderByDescending(x => x);

            foreach ( var item in listaNumeroAtt )
                Console.WriteLine(item);
        }
    }
}
