using System;

namespace ModificadoresParametros {
    class Program {
        static void Main(string[] args) {

            //Suponha que se queira uma calculadora para calcular a soma de uma 
            //quantidade variável de valores.

            //int sum = Calculator.Sum(new int[] { 3, 2, 5}); //Sem o params no arg
            int sum = Calculator.Sum(3, 2, 5); //Com o params no arg

            Console.WriteLine(sum);
        }
    }
}
