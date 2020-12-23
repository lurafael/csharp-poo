using System.Globalization;

namespace AutoProperties {
    class Produto {

        //Sequência recomendada:
        //1º Atributos Privativos
        //2º Auto Properties
        //3º Construtores
        //4º Propriedades Customizadas
        //5º Métodos

        private string _nome;

        public double Preco { 
            get;
            private set; 
        }

        public int Quantidade { 
            get; 
            private set; 
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set { _nome = Nome; }
        }

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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}