using System;
using System.Globalization;

namespace SaidaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string name = "lucas";
            int age = 27;
            double balance = 10.35784;

            //Comandos para saída de dados
            Console.Write("Boa tarde!");        //Não quebra a linha
            Console.WriteLine("Bom dia!");      //Quebra a linha
            
            //Limitando casas decimais
            Console.WriteLine(balance.ToString("F2")); //10,35

            //Formatando para o padrão americano com "." ao invés da "," | OBS: Importar o System.Globalization
            Console.WriteLine(balance.ToString("F2", CultureInfo.InvariantCulture));

            //Imprimir usando Placeholder
            Console.WriteLine("{0} tem {1} anos e tem saldo bancário de: R${2:F2}", name, age, balance); //Imprime com ","
            Console.WriteLine("{0} tem {1} anos e tem saldo bancário de: R${2}", name, age, balance.ToString("F2", CultureInfo.InvariantCulture)); //Imprime com "."

            //Imprimir usando Interpolação
            Console.WriteLine($"{name} tem {age} anos e tem saldo bancário de: R${balance:F2}"); //Imprime com ","
            Console.WriteLine($"{name} tem {age} anos e tem saldo bancário de: R${balance.ToString("F2", CultureInfo.InvariantCulture)}"); //Imprime com "."
        }
    }
}
