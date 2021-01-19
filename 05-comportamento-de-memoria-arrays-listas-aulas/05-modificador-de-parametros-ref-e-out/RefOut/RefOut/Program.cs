using System;

namespace RefOut {
    class Program {
        static void Main(string[] args) {

            //Suponha que se queira uma calculadora com uma operação para triplicar 
            //o valor de um número passado como parâmetro.

            //ref
            int a = 5;

            //Com o ref eu passo o valor real de a, ou seja, 
            //um ponteiro(referencia) para a variável a que vai
            //alterá-la diretamente
            //Obs: O ref exige que a variável seja iniciada
            Calculator.TripleRef(ref a); 
            Console.WriteLine(a);

            //out
            int b = 10;
            int result;

            //O out também passa o valor real de a, a diferença é que ele permite
            //que a variável não seja iniciada. Exemplo:
            Calculator.TripleOut(b, out result);
            Console.WriteLine(result);
        }
    }
}
