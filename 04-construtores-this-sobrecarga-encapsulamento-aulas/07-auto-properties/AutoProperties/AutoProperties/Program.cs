using System;

namespace AutoProperties {
    class Program {
        static void Main(string[] args) {

            Produto p1 = new Produto("TV", 500.0, 10);

            p1.Nome = "TV 4K";

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);
        }
    }
}
