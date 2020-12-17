using System;

namespace exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;

            int opcao = int.Parse(Console.ReadLine());

            while(opcao != 4) {
                if (opcao == 1)
                    alcool++;
                else if (opcao == 2)
                    gasolina++;
                else if (opcao == 3)
                    diesel++;

                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
