namespace Core.Entities.Concrete
{
    public class UserTaxCalculation : IEntity
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CalculationDate { get; set; }
        public string PostalCode { get; set; }
        public double TaxCalculation { get; set; }
        public double AnnualIncome { get; set; }




    }
}
