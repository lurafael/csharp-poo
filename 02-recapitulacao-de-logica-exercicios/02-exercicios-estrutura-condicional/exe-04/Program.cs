using System;

namespace exe_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int startTime = int.Parse(data[0]);
            int endTime = int.Parse(data[1]);
            int endGame;

            if (startTime < endTime)
                endGame = endTime - startTime;
            else
                endGame = 24 - startTime + endTime;

            Console.WriteLine($"O JOGO DUROU {endGame} HORA(S)");

        }
    }
}
