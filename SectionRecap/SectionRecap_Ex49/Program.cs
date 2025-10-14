namespace SectionRecap_Ex49 {
    internal class Program {
        static void Main(string[] args) {
            List<Pet> pets = new() {
                new Pet("Nick", 7, "Au Au"),
                new Pet("Feijão", 3, "Miau miau"),
                new Pet("Rex", 10, "Au Au")
            };

            foreach (Pet pet in pets)
                Console.WriteLine($"O pet {pet.Nome} faz {pet.Som} e tem {pet.Idade} anos!");
        }
    }
}
