using System;

namespace EstruturaRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura repetitiva while

            // Melhor opção quando não sabemos exatamente quantas vezes precisaremos passar pelo loop.

            // Fazer um programa que só saia do loop quando for digitado 0 e some os valores digitados
            //pelo usuário
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0) {
                sum += number;
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Saiu do loop, soma dos números digitados: {sum}");

            //Estrutura repetitiva do while

            //		Quase igual ao while, nessa sempre a condição é executada uma vez
            //		enquanto no while antes de executar vai sempre verificar
        }
    }
}
