using System;

namespace OpComparativosELogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores Comparativos
            //Retorna valores booleanos
            Console.WriteLine($"10 < 5 {10 < 5}");    //false
            Console.WriteLine($"10 > 5, {10 > 5}");    //true
            Console.WriteLine($"10 >= 5, {10 >= 5}");  //true
            Console.WriteLine($"10 <= 5, {10 <= 5}");  //false

            //Operadores Lógicos
            // && -> E
            // || -> OU
            // ! -> NÃO

            //Precedência de operadores
            // ! > && > || 

            // && precisa ter todas as condições atendidas para ter um resultado final Verdadeiro
            Console.WriteLine(10 <= 10 && 5 == 5); // true
            Console.WriteLine(5 <= 20 && 5 == 10); // false

            // || precisa ter pelo menos uma condição atendida para ter um resultado Verdadeiro
            Console.WriteLine(10 <= 10 || 5 < 5); // true
            Console.WriteLine(5 == 20 || 5 == 10); // false

            // ! nega o resultado original das expressões
            Console.WriteLine(!(10 == 10));
        }
    }
}
