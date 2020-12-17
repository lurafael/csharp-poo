using System;

namespace CondicionalEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Estrutura condicional (if-else)
            Console.WriteLine("Quantas horas?"); // Quantas horas?

            int horas = int.Parse(Console.ReadLine());

            if (horas < 12) // Se horas for menor que 12,
                Console.WriteLine("Bom dia"); //Imprime bom dia...
            else
                Console.WriteLine("Boa tarde"); //Senão, imprime boa tarde!

            //Posso usar o else if caso tenha mais possibilidades:)

            //Escopo e inicialização

            //Em C# uma variável não pode ser usada se não for inicializada, em C traria 
            //lixo de memória, mas em C# a IDE vai acusar erro

            //Respeita o escopo de onde foi criada, por exemplo se uma variável for criada
            //dentro de um for, ela só existe lá dentro.

            //O escopo maior não enxerga variáveis que estão em um escopo menor que a dele,
            //uma variável de fora de um if chamar uma variável que está dentro do if por exemplo.
        }
    }
}
