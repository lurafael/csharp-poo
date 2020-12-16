using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sala?");
            int bedrooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] data = Console.ReadLine().Split(' ');

            string lastName = data[0];
            int age = int.Parse(data[1]);
            double height = double.Parse(data[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(bedrooms);
            Console.WriteLine(productPrice.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("f2", CultureInfo.InvariantCulture));

        }
    }
}
