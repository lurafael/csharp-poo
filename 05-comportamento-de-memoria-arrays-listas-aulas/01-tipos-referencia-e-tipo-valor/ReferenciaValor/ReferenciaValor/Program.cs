using System;

namespace ReferenciaValor {
    class Program {
        static void Main(string[] args) {
            //Tipo referência
            //Classes são tipo referencia. Quando usamos o new e instanciamos uma classe, o que
            //é guardado na variável é a referência(ponteiro) para onde foi alocado o objeto
            //Posso definir como null para indicar que a variável não aponta pra ninguém

            //Tipos valor
            //Os structs(tipos primitivos e os customizados também) são tipo valor, em que os 
            //valores são copiados para a outra variável invés de apontar. Posso criar meus próprios
            //structs da seguinte maneira (Ver classe Point)

            //Inicializando o struct
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p); // (10, 20)

            p = new Point();
            Console.WriteLine(p); // (0, 0)

            //Mesmo que for tipo struct eu tenho que inicializar, ou setando valores igual no 
            //primeiro exemplo, ou instanciando com o new.

            //A simples declaração do struct já cria as "caixinhas" na memória e fica esperando os
            //valores, ao contrário das classes que essas "caixinhas" são criadas na hora da
            //instanciação com o new

            //quando alocamos com o new, seja classe, struct, array, são atribuídos valores padrão
            //aos seus elementos:
            //números: 0
            //bool: False
            //char: charactere código 0
            //objeto: null

            //Por isso que na segunda impressão do p, o resultado foi (0, 0).
            
            //Uma variável que não é instanciada, somente é declarada entra em estado "não atribuído"
            //e o compilador não permite que ela seja acessada.
        }
}
}

