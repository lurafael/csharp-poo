using System;
using SavingsAndBusinessAccount.Entities;

namespace SavingsAndBusinessAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting
            //Consegue naturalmente receber uma subclasse, porque o BusinessAccount e SavingsAccount
            //são Account e isso é Upcasting
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //Obs: Se eu tentar chamar o método LoanLimit com o acc2 não será possível, porque agora ele é
            //um Account, e somente o método BusinessAccount tem esse método.

            //Downcasting
            //Não consegue receber uma superclasse, é necessário fazer a conversão para ser possível.
            BusinessAccount acc4 = (BusinessAccount)acc2;

            //Não dá erro aqui, mas em tempo de execução sim, porque BusinessAccount não é compatível com SavingsAccount.
            //Usar o downcasting só quando necessário, evitar sempre que der.
            //BusinessAccount acc5 = (BusinessAccount) acc3; 

            //Operador is
            //Testando se a variável acc3 é uma instância de BusinessAccount, e se for, aí sim faz a conversão
            //False, acc3 não é uma instância de BusinessAccount
            if (acc3 is BusinessAccount) 
            {
                BusinessAccount acc6 = (BusinessAccount)acc3;
                acc6.Loan(200.0);
                Console.WriteLine($"Successful Loan");
            }

            //True, acc3 passou por um processo de upcasting de SavingsAccount para Account, então é uma instância de SavingsAccount
            if (acc3 is SavingsAccount) 
            {
                SavingsAccount acc6 = (SavingsAccount)acc3;
                acc6.UpdateBalance();
                Console.WriteLine($"Successful Update");
            }

            //Operador as
            //Existe uma outra forma de fazer o casting, com o operador as:
            //BusinessAccount acc6 = acc3 as BusinessAccount;
        }
    }
}
