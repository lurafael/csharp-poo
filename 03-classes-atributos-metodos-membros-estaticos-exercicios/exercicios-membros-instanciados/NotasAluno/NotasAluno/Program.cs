using System;
using System.Globalization;

namespace NotasAluno {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            
            if(aluno.VerificaAprovacao())
                Console.WriteLine("APROVADO");
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {aluno.FaltamQuantosPontos()} PONTO(S)" );
            }

        }
    }
}
