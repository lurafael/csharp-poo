using System;

namespace exe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > -1)
                Console.WriteLine("NAO NEGATIVO");
            else
                Console.WriteLine("NEGATIVO");
        }
    }
}
