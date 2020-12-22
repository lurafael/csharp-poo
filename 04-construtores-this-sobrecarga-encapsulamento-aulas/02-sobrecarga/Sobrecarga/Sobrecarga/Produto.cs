using System.Globalization;

namespace Sobrecarga {
    class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Estou permitindo que a classe Produto seja instanciada apenas se tiver 3 argumentos iniciais,
        //e que eles serão adicionados as variaveis acima, sendo assim, é obrigatório o uso dos 3
        //argumentos para o programa rodar...
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Mas posso configurar por exemplo para que também funcione caso seja informado apenas os 2
        //primeiros valores e a quantidade seja um valor pré definido...
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        //Ou que possa ser instanciado sem argumentos também...
        public Produto() {

        }

        //Tudo depende da necessidade da aplicação. Com a sobrecarga eu gerencio como a instanciação
        //vai ocorrer.

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
