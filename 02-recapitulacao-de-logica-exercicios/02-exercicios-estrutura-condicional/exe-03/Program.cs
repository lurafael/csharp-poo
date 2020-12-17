using System;

namespace exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' '); 
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);

            if(a % b == 0 || b % a == 0)
                Console.WriteLine("SAO MULTIPLOS");
            else
                Console.WriteLine("NAO SAO MULTIPLOS");
        }
    }
}
