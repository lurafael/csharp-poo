using System;

namespace DesalocacaoNullable {
    class Program {
        static void Main(string[] args) {
            //Desalocação de memória Stack e Heap
            //O garbage collector é responsável por desalocar a memória dinâmica(heap) depois que
            //ela fica um tempo sem referência

            //No stack tudo é desalocado por escopo, assim que sai de execução... Mas continua
            //existindo no heap, e enquanto essa referência continuar existindo não vai ser
            //desalocado pelo garbage collector

            //Nullable
            //As variáveis do tipo struct não podem receber valores do tipo null, somente as de tipo
            //referência, logo, posso usar o Nullable porque alguma vez posso precisar de uma variável
            //sem inicializá-la, como em campos de banco de dados ou dados e parâmetros opcionais

            //double x = null; //Não permitido
            double? x = null; // Null - O "?" diz que é opcional o x ter valor ou não
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault()); // 0 - Pega o valor de x, ou se for null, pega o valor padrão(de números é 0)
            Console.WriteLine(y.GetValueOrDefault()); // 10 - Pegou o valor

            Console.WriteLine(x.HasValue); // False - É nulo, ou seja, sem valor
            Console.WriteLine(y.HasValue); // True - Tem valor

            //Console.WriteLine(x.Value); // Lança uma exceção caso seja null
            Console.WriteLine(y.Value); // Mostra o valor

            //Operador de coalescência nula
            double? a = null;
            double b = a ?? 0.0; //Se o valor não for nulo atribui em b, se for nulo, atribui o 0.0
        }
    }
}
