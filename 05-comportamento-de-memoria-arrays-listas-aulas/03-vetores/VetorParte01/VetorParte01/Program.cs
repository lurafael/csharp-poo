using System;
using System.Globalization;

namespace VetorParte01 {
    class Program {
        static void Main(string[] args) {

            int qtdePessoas = int.Parse(Console.ReadLine());
            double[] vect = new double[qtdePessoas]; //Cria e aloca no heap um vetor com a qtdePessoas digitadas
            double soma = 0.0;

            for(int i = 0; i < qtdePessoas; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += vect[i];
            }

            double media = soma / qtdePessoas;

            Console.WriteLine("AVERAGE HEIGHT = "
                + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
