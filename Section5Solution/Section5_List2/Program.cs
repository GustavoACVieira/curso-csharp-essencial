namespace Section5_List2 {
    internal class Program {
        static void Main(string[] args) {
            var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

            /*lista.Add("Marta");

            lista.Insert(2, "Bia");

            Console.WriteLine(lista.Count + " itens");*/

            //A parte de add coleção, remover, ordenar é igual a array list

            //Acessando elemento é igual array(por meio de um indexador)
            
            //Usando for
            for (int i = 0; i < lista.Count; i++) {
                Console.WriteLine($"{lista[i]} ");
            }

            Console.WriteLine();

            //Usando foreach
            foreach (var str in lista) {
                Console.WriteLine(str);
            }

            //A parte de buscar(Contains) é igual Arraylist

            //Ordenação e Remoção é igual a ArrayList tbm

            //List não faz unboxing e boxing, é mais segura e mais rápida
        }
    }
}
