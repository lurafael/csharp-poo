using System;

namespace This {
    class Program {
        static void Main(string[] args) {

            //O this referencia o objeto que ele está.

            //1ª aplicação do this 
            //Seria quando por exemplo em JS ou Java que montamos o construtor e
            //precisamos diferenciar variável de parâmetro e atributo declarado na classe
            //daí precisamos usar o this.nome(atributo da classe) = nome(variável de parâmetro)
            //Em C# não temos esse problema, afinal, atributos usam Pascal Case e variáveis de 
            //parâmetros usam Camel Case.

            //2ª aplicação do this
            //Seria quando preciso usar atributo(s) de outro construtor dentro do meu construtor
            //Exemplo:

            //Tenho dentro de uma classe Produto, o construtor Produto que possui a Quantidade = 0 
            //por padrão.
            //public Produto() {
            //    Quantidade = 0;
            //}

            //Uso o this com chave vazia para dar referenciar meu construtor padrão, posso assim
            //usar o Quantidade = 0 que ele possui (Seria como se fosse: Pega o Produto() e deixa
            //visível pra mim), afinal this é o Produto nesse caso.
            //public Produto(string nome, double preco) : this() {
            //    Nome = nome;
            //    Preco = preco;
            //}

            //Consigo referenciar o construtor de 2 parâmetros da mesma forma
            //Seria como se fosse: Pega o Produto(nome, preco) e deixa visível pra mim
            //public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            //    Quantidade = quantidade;
            //}

            //Isso evita ter que ficar fazendo sobrecarga com os mesmos valores toda hora
            //por exemplo, porque vc referencia quais atributos vai aproveitar inves de 
            //digitá-los denovo.

            //3ª aplicação do this
            //Passar o próprio objeto como argumento na chamada de um método ou construtor
            
            //Por exemplo:
            
            //class ChessMatch {
            //(...)
            //PlaceNewPiece('e', 1, new King(board, Color.White, this));
            //(...)

            //Nesse exemplo acima, ele está chamando a própria classe quando for executada essa
            //função PlaceNewPiece

        }
    }
}
