using System;

namespace Properties {
    class Program {
        static void Main(string[] args) {

            Produto p1 = new Produto("TV", 500.0, 10);

            p1.Nome = "TV 4K"; //Consigo acessar porque o Nome tem get e set
            //p1.Preco = 500.0; //Não consigo acessar, é somente de leitura pois só tem o get

            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);
        }
    }
}
