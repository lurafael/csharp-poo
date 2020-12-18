using System;

namespace exe_02 {
    class Program {
        static void Main(string[] args) {
            
            int inRange = 0, outRange = 0;
            int necessaryRepetitions = int.Parse(Console.ReadLine());

            for(int i = 0; i < necessaryRepetitions; i++) {
                int number = int.Parse(Console.ReadLine());

                if(number >= 10 && number <= 20)
                    inRange++;
                else
                    outRange++;
            }

            Console.WriteLine("\n" + inRange + "in");
            Console.WriteLine(outRange + "out");

        }
    }
}
