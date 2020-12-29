using System;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {

            Bedroom[] bedroom = new Bedroom[10];

            Console.Write("Quantos quartos serão alugados? ");
            int rentingRooms = int.Parse(Console.ReadLine());

            for(int i = 1; i <= rentingRooms; i++) {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int bedroomNumber = int.Parse(Console.ReadLine());

                bedroom[bedroomNumber] = new Bedroom(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < bedroom.Length; i++) {
                if(bedroom[i] != null) {
                    Console.WriteLine($"{i}: {bedroom[i].Name}, {bedroom[i].Email}");
                }
            }
        }
    }
}
