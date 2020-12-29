using System;
using System.Collections.Generic; //Precisa importar para poder usar as listas

namespace Listas {
    class Program {
        static void Main(string[] args) {

            //List 
            //• Lista é uma estrutura de dados:
            //• Homogênea(dados do mesmo tipo)
            //• Ordenada(elementos acessados por meio de posições)
            //• Inicia vazia, e seus elementos são alocados sob demanda
            //• Cada elemento ocupa um "nó"(ou nodo) da lista

            //Vantagens:
            //• Tamanho variável
            //• Facilidade para se realizar inserções e deleções
            //• Desvantagens:
            //• Acesso sequencial aos elementos *

            //List<string> listExemplo = new List<string> { "Maria", "Alex" }; //Cria lista elementos
            List<string> list = new List<string>();

            //Add(Adicionar itens a lista)
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //Insert(Inserir itens a lista)
            list.Insert(2, "Marco");

            foreach(string person in list) {
                Console.WriteLine(person);
            }

            Console.WriteLine("-------------------------");

            //Count(Contar o tamanho da lista)
            Console.WriteLine("List Count: " + list.Count);

            Console.WriteLine("-------------------------");

            //Find, FindLast, FindIndex, FindLastIndex e FindAll(Encontrar algo na lista)
            //o Find recebe uma função por parâmetro, que é a condição de busca na lista, e 
            //retorna o primeiro resultado encontrado
            string s1 = list.Find(letter => letter[0] == 'A'); //Estilo arrow function(Expressão Lambda aqui)
            Console.WriteLine("First A: " + s1);

            //FindLast
            string s2 = list.FindLast(letter => letter[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //FindIndex
            int pos1 = list.FindIndex(letter => letter[0] == 'A');
            Console.WriteLine("First A (Index): " + pos1);

            //FindLastIndex
            int pos2 = list.FindLastIndex(letter => letter[0] == 'A');
            Console.WriteLine("Last A (Index): " + pos2);

            //FindAll(Filtrar lista, ou seja, criar uma nova lista que atenda condições (Map em JS))
            List<string> list2 = list.FindAll(letter => letter.Length == 5);

            Console.WriteLine("-------------------------");

            foreach(string hasFiveLetter in list2) {
                Console.WriteLine("Five letters names: " + hasFiveLetter);
            }

            Console.WriteLine("-------------------------");

            ////Remove(Remover da lista)s
            //list.Remove("Alex");

            ////RemoveAll
            //list.RemoveAll(x => x[0] == 'M');

            //RemoveRange - A partir do índice 2, remove o próprio índice 2 e o próx. nesse caso
            //list.RemoveRange(2, 2); //É igual ao splice do JS nos 2 primeiros parâmetros

            //RemoveAt - Remove quem estiver no índice 2
            //list.RemoveAt(2);

            foreach(string person in list) {
                Console.WriteLine(person);
            }

            //Se tentar remover alguem que não existe na lista, não remove nada nem da erro.
        }
    }
}
