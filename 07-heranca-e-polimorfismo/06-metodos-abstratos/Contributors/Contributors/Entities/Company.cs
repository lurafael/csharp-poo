namespace Contributors.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double annualIncome) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if(NumberOfEmployees < 10)
            {
                return AnnualIncome * 0.16;
            }
            return AnnualIncome * 0.14;
        }
    }
}
