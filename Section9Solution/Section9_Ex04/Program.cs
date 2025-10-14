using System.Threading.Channels;

namespace Section9_Ex04 {
    internal class Program {
        static void Main(string[] args) {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa("João", 20));
            pessoas.Add(new Pessoa("Maria", 18));
            pessoas.Add(new Pessoa("Pedro", 25));
            pessoas.Add(new Pessoa("Carlos", 15));
            pessoas.Add(new Pessoa("Ana", 17));

            Action<Pessoa> actPessoa = x => Console.WriteLine($"Nome: {x.Nome} - Idade: {x.Idade}");
            pessoas.ForEach(actPessoa);

            Console.WriteLine();

            Predicate<Pessoa> predPessoa = x => x.Idade > 18;
            var pessoasMaior18 = pessoas.FindAll(predPessoa);
            pessoasMaior18.ForEach(actPessoa);

            Console.WriteLine();

            Func<Pessoa, int> maxPessoa = x => x.Idade;

            var pessoaMaisVelha = pessoas.MaxBy(maxPessoa);

            //var idadeMax = pessoas.Max(maxPessoa);

            //var pessoaMaisVelha = pessoas.Find(x => x.Idade == idadeMax);

            Console.WriteLine($"A pessoa mais velha é: {pessoaMaisVelha.Nome} com {pessoaMaisVelha.Idade} anos");
        }
    }
}
