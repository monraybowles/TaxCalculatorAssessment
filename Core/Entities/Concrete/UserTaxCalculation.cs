namespace Core.Entities.Concrete
{
    public class UserTaxCalculation : IEntity
    {
        public Guid Id { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CalculationDate { get; set; }
        public string PostalCode { get; set; }
        public decimal TaxCalculation { get; set; }
        public decimal AnnualIncome { get; set; }




    }
}
