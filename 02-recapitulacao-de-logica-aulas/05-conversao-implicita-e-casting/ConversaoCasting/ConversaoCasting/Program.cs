using System;

namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita de tipos
            float x = 4.5f; 
            double y = x; //O x é float e foi atribuído em y que é double, e um float cabe em um double então funciona.

            double a = 5.1f;
            float b = (float) a;
            //O double não cabe em um float, então é feito um casting, que é uma conversão implícita de tipos.
            //O dev se responsabiliza pela possível perda de informações (exatidão do double);
            //Mesma coisa de um double para int, ele vai truncar o valor e devolver só a parte inteira.

            //Se eu tiver valores inteiros mas quiser um resultado double, faço o casting 
            int n1 = 5, n2 = 2;
            double resultado = (double) n1 / n2;

            Console.WriteLine(resultado);
        }
    }
}
