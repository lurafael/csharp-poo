using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            //Para ler do teclado, usar o Console.ReadLine() - Funciona para Strings, 
            //para funcionar com números usar o int.Parse(), double.Parse()...

            //Ler do teclado no formato abaixo:
            //Bom dia!
            //Vermelho
            //Verde
            //Azul
            //Amarelo Laranja Cinza

            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            //Posso pegar vários valores de uma vez antes da quebra de linha
            //e distribuir para as variáveis usando o split e informando qual posição 
            //do vetor vai para tal variável
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //Se for preciso digitar "." ao invés da "," precisa importar o System.Globalization,
            //por conta da linguagem do teclado estar em Pt-br, reconhecendo a "," como separador.
            //Caso eu digite 4.32, ele vai imprimir 432, para resolver, importo o Globalization e
            //coloca o CultureInfo.InvariantCulture, para ele reconhecer o "." como separador.
            
            //Não esquecer de colocar o formatador no WriteLine que mostra o resultado também, senão
            //o resultado continua sendo com vírgula.
            double n1br = double.Parse(Console.ReadLine());
            double n1usa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(n1br.ToString("F2"));
            Console.WriteLine(n1usa.ToString("F2"), CultureInfo.InvariantCulture);

            //Ler do teclado no formato abaixo:
            //35
            //F
            //4.32
            //Maria F 23 1.68

            int n1 = int.Parse(Console.ReadLine());
            string ch = Console.ReadLine();
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Mesmo esquema de cima, mas como tem valores de diferentes tipos agora,
            //preciso parsear cada valor que não for string antes de entregar para sua variável
            string[] vet2 = Console.ReadLine().Split(' ');
            string nome = vet2[0];
            char sexo = char.Parse(vet2[1]);
            int idade = int.Parse(vet2[2]);
            double altura = double.Parse(vet2[3], CultureInfo.InvariantCulture);

            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
