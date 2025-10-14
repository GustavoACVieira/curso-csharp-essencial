namespace SectionRecap_Ex16 {
    internal class Program {
        static void Main(string[] args) {
            Repository<string> repositoryStr = new();
            Repository<int> repositoryInt = new();

            repositoryStr.Add("Gustavo");
            repositoryStr.Add("Rodrigo");
            repositoryStr.Add("Leo");

            repositoryInt.Add(1);
            repositoryInt.Add(10);
            repositoryInt.Add(100);

            var resultStr = repositoryStr.ListAll();
            foreach (var rstStr in resultStr)
                Console.WriteLine(rstStr);

            var resultInt = repositoryInt.ListAll();
            foreach (var rstInt in resultInt)
                Console.WriteLine(rstInt);
        }
    }
}
