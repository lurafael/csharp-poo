using System;
using System.Collections.Generic;

namespace Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);
            //OBS: Se eu tentar adicionar um número repetido no conjunto, não vai adicionar

            foreach(int conjItem in A) {
                Console.WriteLine(conjItem);
            }

            Console.WriteLine("Digite um valor inteiro:");
            int N = int.Parse(Console.ReadLine());

            if(B.Contains(N))
                Console.WriteLine("Pertence ao conjunto B");
            else
                Console.WriteLine("Não pertence ao conjunto B");

            B.Remove(4); //Remove o elemento 4 do conjunto B

            A.ExceptWith(B); //Remove todo mundo de A que pertence a B *Diferença de conjuntos*
            A.UnionWith(B); //Altera o A e guarda a união em A
            A.IntersectWith(B); //Pega a intersecção de A e B

        }
    }
}
