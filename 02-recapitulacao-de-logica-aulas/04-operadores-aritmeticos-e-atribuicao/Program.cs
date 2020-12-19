using System;

namespace OperadoresAritAtrib
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritméticos
            //Ordem de precedência ! () * / % + - 

            //Exemplo
            int n1 = 3 + 4 / 2; //Primeiro é feita a divisão e depois a soma
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2; //Como o parênteses é a maior precedencia que o * é feito antes
            Console.WriteLine(n2);

            //Calculando a fórmula de bhaskara para entender melhor a precedência
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            //Operadores de atribuição cumulativa
            int x = 5;
            int y = 10;
            string s = "ABC";

            Console.WriteLine(x += y); // x = x + y = 15
            Console.WriteLine(x *= y); // x = x * y = 150
            Console.WriteLine(x %= y); // x = x % y = 0
            Console.WriteLine(s += "DEF"); //ABCDEF

            //Pré e pós incremento
            int incremento = 10;
            int preIncremento = --incremento; //Decrementa a variável incremento e joga ela para a variável preIncremento
            Console.WriteLine("Pré incremento: " + preIncremento);

            incremento = 10;
            int posIncremento = incremento--; //Joga o incremento para posIncremento e decrementa a variável incremento

            Console.WriteLine("Pós incremento: " + posIncremento);
            Console.WriteLine("Pré incremento: " + posIncremento);
        }
    }
}
