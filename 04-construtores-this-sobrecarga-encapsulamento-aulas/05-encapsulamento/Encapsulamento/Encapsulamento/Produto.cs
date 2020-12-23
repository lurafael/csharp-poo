using System.Globalization;

namespace Encapsulamento {
    class Produto {

        //public string Nome;
        //public double Preco;
        //public int Quantidade;

        //Para começar: 
        // - Tiramos o acesso aberto dos atributos com a chave private;
        // - Usamos o _ e começando com letra minúscula;
        // - Criamos os getters e setters;

        private string _nome;
        private double _preco;
        private int _quantidade;

        public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            _nome = nome;
        }

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}