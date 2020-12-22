
//Quando um item é instanciado como no caso do exercício abaixo o "p", eles vem vazios, por ex:
//O nome é string e vem null, o preco é double e vem 0.0 e a quantidade é int vem 0.
//Como não faz sentido isso, existe uma maneira de fazer com que o programador seja obrigado a 
//definir valores na hora de instanciar (Olhar na classe Produto).

using System;
using System.Globalization;

namespace Construtores {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Primeiro peço normalmente para o usuário as informações e depois instancio
            //já com os valores definidos, evitando aquela instanciação de valores nulos e 0.
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}