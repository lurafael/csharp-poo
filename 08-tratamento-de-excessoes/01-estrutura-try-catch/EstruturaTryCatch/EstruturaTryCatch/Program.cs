using System;

namespace EstruturaTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Quando fazemos uma divisão por 0 por exemplo, é lançada uma excessão... Onde ela detalha o "Stack Trace":
            //Tipo da excessão, a mensagem padrão dela e onde a excessão ocorreu, então tem como tratar com o try-catch,
            //que então vai parar de quebrar o programa e capturar a excessão para tratar ou mostrar em algum log...

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }

            //Permite o Upcasting, logo, se eu colocar "Exception e" no parâmetro do catch ele aceita... Upcasting porque
            //o DivideByZeroException é uma "subclasse" do "Exception" que é a "superclasse" de todas excessões

            //Então sempre usar o tipo de excessão mais específico possível como no caso aqui o "DivideByZeroException"
            //podendo tratar do melhor jeito possível esse erro de divisão por 0 sem quebrar o programa mas saber que
            //teve esse erro

            //Se eu digito letras ao invés de números ele dá outro tipo de excessão: "FormatException", vamos capturar
            //também esse exception

            catch (FormatException e)
            {
                Console.WriteLine("Format error!" + e.Message);
            }

            //Bloco finally
            //Executa algo independente de ter dado certo ou nao o try-catch... Geralmente é usado para fechar
            //arquivo ou conexão com banco de dados ao final do processamento
        }
    }
}
