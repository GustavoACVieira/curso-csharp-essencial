namespace Section5_List1 {
    internal class Program {
        static void Main(string[] args) {
            //Formas de se declarar e inicializar
            List<string> lista;
            lista = new List<string>();

            List<int> lista1 = new List<int>();
            var lista2 = new List<float>();
            List<double> lista3 = new();

            List<string> nomes = new();

            //Add
            nomes.Add("Paulo");
            nomes.Add("Maria");

            var lista4 = new List<string>() { "Paulo", "Maria", "Bia", "Pedro" };

        }
    }
}
