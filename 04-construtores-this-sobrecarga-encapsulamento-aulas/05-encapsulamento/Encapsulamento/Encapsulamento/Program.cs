using System;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            //Encapsulamento consiste em esconder detalhes da implementação dos componentes,
            //expondo somente as partes seguras, por exemplo, um rádio tem vários circuitos e conexões
            //que faz seu funcionamento, mas é escondido por uma carcaça e botões para que o usuário
            //somente aperte em botões e tal que é a parte segura.

            //Em programação, o objeto deve estar em um estado consistente e a classe deve garantir 
            //isso

            //todo atributo é definido como private
            //implementa-se métodos get e set para cada atributo

            //OBS: não é muito usado em C#, pois existem as properties

            //A idéia é não permitir que o usuário faça alterações diretamente, mas que a classe 
            //Produto seja responsável por fazer tudo, assim como no exemplo do rádio não queremos
            //que o usuário mexa nos circuitos para ligar o rádio e altere as coisas, o rádio tem
            //que se manter funcionando com o usuário tendo acesso ao botão de funcionar...

            //Então não queremos que seja possível isso:

            Produto produto = new Produto("TV", 900.00, 10);
            //produto.Quantidade = -10; //Seria o usuário alterando o programa de forma fácil

            //Ver encapsulamento na classe Produto...

            //Imprimindo o nome do produto já com as implementações do get
            Console.WriteLine(produto.GetNome());

            //Trocando TV por TV 4K usando o set e imprimir
            produto.SetNome("TV 4K");
            Console.WriteLine(produto.GetNome());

        }
    }
}
