using System;
using System.Globalization;

namespace VetorParte02 {
    class Program {
        static void Main(string[] args) {
            
            int qtdeProdutos = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[qtdeProdutos];
            double media = 0.0;

            //Na instanciação acima foi criado um array com o tanto de índices definidos no 
            //qtdeProdutos e criados no heap por conta do new. Todos os índices possuem valores
            //nulos, pois é o padrão na hora da instanciação

            for(int i = 0; i < qtdeProdutos; i++) {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Como cada índice do vetor é do tipo Produto, mas seu valor está como nulo, 
                //é necessário instanciar um novo Produto para jogar os valores lá, que vai
                //instanciar no heap nome e preço, e devolver no índice o end. de memória para
                //acessar esses dados.
                //Uso aqui a sintaxe alternativa de instanciação
                produtos[i] = new Produto { Nome = nome, Preco = preco };
                media += produtos[i].Preco;
            }

            media /= qtdeProdutos;

            Console.WriteLine("AVERAGE PRICE = " 
                + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
