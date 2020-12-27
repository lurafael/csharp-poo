
//Sintaxe alternativa para instanciar nesse caso um Produto.

using System;
using System.Globalization;

namespace SintaxeAlternativa {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //Forma já aprendida

            Produto p2 = new Produto { //Sintaxe Alternativa 1
                Nome = "XBOX",
                Preco = 2500.00,
                Quantidade = 50
            };

            Produto p3 = new Produto() { //Sintaxe Alternativa 2
                Nome = "PS5",
                Preco = 2500.00,
                Quantidade = 50
            };

            //Ambas funcionam livremente desde que não tenha uma sobrecarga com alguma regra 
            //excluindo algum dos atributos que estão aqui tentando ser instanciados no programa
            //principal.

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
