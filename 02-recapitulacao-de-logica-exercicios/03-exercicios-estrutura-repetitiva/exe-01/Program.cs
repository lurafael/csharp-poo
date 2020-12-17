using System;

namespace exe_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int senhaCorreta = 2002;
            int senhaDigitada = int.Parse(Console.ReadLine());

            while (senhaDigitada != senhaCorreta) {
                Console.WriteLine("Senha Inválida");
                senhaDigitada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
