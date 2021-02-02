namespace SobreposicaoVirtualOverrideBase.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //Quando digitado override + Espaço, aparece a lista dos métodos que podem ser sobrescritos, dentre eles o Withdraw
        //como definido com a palavra virtual
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Chama o método Withdraw da classe Withdraw e...
            Balance -= 2.0; //Desconta mais 2 reais que era o pedido no exercício
        }
    }
}
