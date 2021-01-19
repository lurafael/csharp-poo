using System;

namespace BoxingUnboxing {
    class Program {
        static void Main(string[] args) {
            //É um processo de conversão de um objeto tipo valor para um objeto tipo
            //referência compatível

            //boxing
            int x = 20; //tipo valor
            Object obj = x; //tipo referência

            //Quando coloco o x em obj, estou criando no heap um novo obj com o valor de
            //x, afinal tipo referência sempre usa o heap

            //unboxing
            int x2 = (int) obj;
            Console.WriteLine(x2);

            //Quando faço esse casting, e sendo compatível (obj é compatível com todos)
            //então o x2 q está no stack vai receber o valor que estava no heap, sem criar
            //nenhuma operação a mais por isso
        }
    }
}
