using System;

namespace Foreach {
    class Program {
        static void Main(string[] args) {

            string[] people = new string[]
            { "Lucas", "Rafael", "Ricci", "Caju", "Cacau", "Miriã" };

            foreach(string person in people) {
                Console.WriteLine(person); 
            }

            //O foreach passa por cada índice do vetor people, jogando seu valor 
            //temporário em person, até o último índice
        }
    }
}
