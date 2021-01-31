namespace BusinessAccount.Entities
{
    class Account
    {

        //Com o modificador de acesso "protected", somente a classe ou subclasse podem fazer alterações,
        //não deixando assim a classe Program alterar diretamente informações por exemplo. Já com o private,
        //somente a classe pode alterar algo.

        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }


        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
