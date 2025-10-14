using System.Runtime.Intrinsics.X86;

namespace SectionRecap_Ex03 {
    internal class Program {
        static void Main(string[] args) {
            //Use uma List<double> para armazenar as notas de um aluno.
            //Calcule e exiba:
            //A média das notas
            //A maior e menor nota

            List<double> notas = new List<double>();
            double maiorNota = double.MinValue, mediaNota = 0, menorNota = double.MaxValue;

            while (true) {
                Console.WriteLine("Informe a nota do aluno: ");
                double nt = Convert.ToDouble(Console.ReadLine());

                if (nt < 0)
                    break;

                notas.Add(nt);

                if (nt > maiorNota)
                    maiorNota = nt;
                else if (nt < menorNota)
                    menorNota = nt;

                mediaNota += nt;
            }

            mediaNota = mediaNota / notas.Count;
            Console.WriteLine($"Maior nota: {maiorNota}\nMenor nota: {menorNota}\nMédia de Notas: {mediaNota.ToString("F2")}");
        }
    }
}
