namespace Section13 {
    internal class Program {
        static void Main(string[] args) {
            //Fundamentos 1
            IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

            //Query Syntax
            var resultadoQ = from f in frutas
                             where f.Contains('r')
                             select f;
            Console.WriteLine(string.Join(" - ", resultadoQ));

            //Method Syntax
            var resultadoM = frutas.Where(f => f.Contains('r'));

            Console.WriteLine(string.Join(" - ", resultadoM));
        }
    }
}
