using System;

namespace exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int x = int.Parse(data[0]);
            int y = int.Parse(data[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("quarto");
                
                data = Console.ReadLine().Split(' ');
                x = int.Parse(data[0]);
                y = int.Parse(data[1]);
            }
        }
    }
}
