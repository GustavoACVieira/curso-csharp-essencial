namespace Section5_Ex10 {
    internal class Program {
        static void Main(string[] args) {
            Aluno aluno = new();

            aluno[0] = "Maria";
            aluno[1] = "Marta";
            aluno[2] = "Carlos";
            aluno[3] = "Manoel";
            aluno[4] = "Joaquim";
            aluno[5] = "Amanda";
            aluno[6] = "Pedro";
            aluno[7] = "Vanessa";
            aluno[8] = "Bruno";
            aluno[9] = "Dionísio";

            string valor1 = aluno[0];
            string valor2 = aluno[1];
            string valor3 = aluno[2];
            string valor4 = aluno[4];
            string valor5 = aluno[5];
            string valor6 = aluno[6];
            string valor7 = aluno[7];
            string valor8 = aluno[8];
            string valor9 = aluno[9];

            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
            Console.WriteLine(valor3);
            Console.WriteLine(valor4);
            Console.WriteLine(valor5);
            Console.WriteLine(valor6);
            Console.WriteLine(valor7);
            Console.WriteLine(valor8);
            Console.WriteLine(valor9);
        }
    }
}
