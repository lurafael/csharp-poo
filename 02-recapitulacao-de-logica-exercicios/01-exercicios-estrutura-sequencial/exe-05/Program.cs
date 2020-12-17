using System;
using System.Globalization;

namespace Exe05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');
            int pieceCode1 = int.Parse(values[0]);  
            int howManyPieces1 = int.Parse(values[1]);
            double valuePiece1 = double.Parse(values[2], CultureInfo.InvariantCulture);

            values = Console.ReadLine().Split(' ');
            int pieceCode2 = int.Parse(values[0]);
            int howManyPieces2 = int.Parse(values[1]);
            double valuePiece2 = double.Parse(values[2], CultureInfo.InvariantCulture);

            double sum = valuePiece1 * howManyPieces1 + valuePiece2 * howManyPieces2;

            Console.WriteLine($"VALOR A PAGAR: {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
