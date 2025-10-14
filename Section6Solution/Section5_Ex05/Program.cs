namespace Section5_Ex05 {
    internal class Program {
        static void Main(string[] args) {
            Pessoa[] pessoas = new Pessoa[3];

            for (int i = 0; i < pessoas.Length; i++) {
                if (i == 0) {
                    Console.WriteLine("Informe o nome do professor: ");
                    pessoas[i] = new Professor(Console.ReadLine());
                } else {
                    Console.WriteLine("Informe o nome do Aluno: ");
                    pessoas[i] = new Aluno(Console.ReadLine());
                }
            }

            for (int i = 0; i < pessoas.Length; i++) {
                if (i == 0) {
                    pessoas[i].ToString();
                    ((Professor)pessoas[i]).Explicando();
                } else {
                    pessoas[i].ToString();
                    ((Aluno)pessoas[i]).Estudar();
                }
            }
        }
    }
}
