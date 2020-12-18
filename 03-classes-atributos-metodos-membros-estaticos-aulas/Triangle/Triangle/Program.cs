using System;
using System.Globalization;

namespace Triangle {
    class Program {

        //Toda a parte comentada era o exercício sem a aplicação de POO

        static void Main(string[] args) {
            
            //o "new" instancia na memória o espaço necessário para toda a estrutura do tipo triângulo
            //existir, e passa o end. de memória para a variável x e y, que tem agora também, acesso a 
            //todos atributos criados na classe Triangle.
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            //double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            //double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double xP = (xA + xB + xC) / 2.0;
            //double xArea = Math.Sqrt(xP * (xP - xA) * (xP - xB) * (xP - xC));

            double xP = (x.A + x.B + x.C) / 2.0;
            double xArea = Math.Sqrt(xP * (xP - x.A) * (xP - x.B) * (xP - x.C));

            //double yP = (yA + yB + yC) / 2.0;
            //double yArea = Math.Sqrt(yP * (yP - yA) * (yP - yB) * (yP - yC));

            double yP = (y.A + y.B + y.C) / 2.0;
            double yArea = Math.Sqrt(yP * (yP - y.A) * (yP - y.B) * (yP - y.C));

            char maiorArea = (xArea > yArea) ? 'X' : 'Y';

            Console.WriteLine("Área de X = " + xArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + yArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior área: " + maiorArea);
        }
    }
}
