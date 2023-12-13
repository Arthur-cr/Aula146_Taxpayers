
namespace Principal.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }
        public Company(string name, double anualIncome, int ne)
            : base(name, anualIncome)
        {
            NumberOfEmployees = ne;
        }
        public override double Tax()
        {
            if (NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
