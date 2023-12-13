
namespace Principal.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public TaxPayer() {}

        protected TaxPayer(string naame, double anualIncome)
        {
            Name = naame;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
