using System;

namespace Matrizes {
    class Program {
        static void Main(string[] args) {
            string[] n = Console.ReadLine().Split(' ');
            int lin = int.Parse(n[0]);
            int col = int.Parse(n[1]);
            int[,] mat = new int[lin, col];

            for(int i = 0; i < lin; i++) {
                string[] data = Console.ReadLine().Split(' ');
                for(int j = 0; j < col; j++) {
                    mat[i, j] = int.Parse(data[j]);
                }
            }

            int searchNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i < lin; i++) {
                for(int j = 0; j < col; j++) {
                    if(mat[i, j] == searchNumber) {
                        Console.WriteLine($"Position {i}, {j}:");
                        if(j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if(i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if(j < col - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if(i < lin - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }
        }
    }
}
