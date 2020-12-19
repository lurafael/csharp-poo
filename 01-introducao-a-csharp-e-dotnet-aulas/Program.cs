using System;
//O using faz referência ao namespace chamado System (que é um namespace padrão do .NET, que contém
//funções básicas de manipulação de programas, então para usar essas funções como por exemplo o
//Console.WriteLine()), precisamos importar esse namespace.

namespace PrimeiroPrograma //Programa Program está dentro desse namespace PrimeiroPrograma
{
    class Program //Por organização e convenção, é colocado o mesmo nome na classe e no programa (Não é obrigatório)
    {
        static void Main(string[] args) //Único membro dentro da class Program, mas podemos ter vários
        {
            Console.WriteLine("Hello World!"); //Único comando dentro do entry point (abre e fecha chaves do Main)
        }
    }
}

//Dicas:
//Identação automática: CTRL + K + D
//Comentar: CTRL + K + C | Descomentar: CTRL + K + U
//Rodar o programa: CTRL + F5
//Aumentar e diminuir a fonte: CTRL + Scroll do mouse