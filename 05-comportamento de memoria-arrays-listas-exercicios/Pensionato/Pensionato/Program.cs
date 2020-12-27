using System;

namespace Pensionato {
    class Program {
        static void Main(string[] args) {

            Student[] student = new Student[10];

            Console.Write("Quantos quartos serão alugados? ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfStudents; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + i);
                
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numberBedroom = int.Parse(Console.ReadLine());

                student[numberBedroom] = new Student(name, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < student.Length; i++) {
                if(student[i] != null)
                    Console.WriteLine($"{i}: {student[i].Name}, {student[i].Email}");
            }
        }
    }
}
