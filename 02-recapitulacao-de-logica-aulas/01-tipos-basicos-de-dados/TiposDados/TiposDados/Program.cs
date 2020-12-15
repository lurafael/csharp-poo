using System;

namespace TiposDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos básicos
            sbyte csharp = 100; //Tipo do C#
            SByte dotnet = 100; //Tipo do .NET - Precisa do namespace System para funcionar
            float number = 4.5f; //Se eu não colocar o f na frente do 4.5 o c# entende que é um valor double

            Console.WriteLine(csharp);
            Console.WriteLine(dotnet);
            Console.WriteLine(number);

            //Tipos referência
            string name = "Lucas Ricci";
            object carro = "Chevrolet Cobalt";

            Console.WriteLine(name);
            Console.WriteLine(carro);

            //Funções para valores mínimos e máximos
            int lowerValue = int.MinValue;
            int higherValue = int.MaxValue;

            Console.WriteLine(lowerValue);
            Console.WriteLine(higherValue);

            //Dica: 
            //Atalho para Console.WriteLine(): digitar cw + tab + tab
        }
    }
}
