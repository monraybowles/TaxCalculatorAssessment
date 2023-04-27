using Business.Abstract;
using Business.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Business.ValidationRules.FluentValidation;
using Moq;

namespace WebWebUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
       /// <summary>
       /// A few methods to test for the testing team to test if certain section of business rules are working.
       /// Coded by Monray Grant Bowles
       /// </summary>
        [TestMethod]
        public void Given_RegisterTaxCalculator_When_Id_DoesNot_Exist_Should_AddTaxCalculator()
        {
            //------------Setup---------------------------------
            var taxCalculator = new FlatRateTaxCalculatorRules(new Mock<IIncomeValidatorService>().Object);
            const string identifier = "Flat Rate";
            var taxResolver = new PostalCodeTaxResolverManager(new Mock<IIncomeValidatorService>().Object);
            //------------Execute--------------------------------
            taxResolver.RegisterTaxCalculator(identifier, taxCalculator);
            //------------Assert--------------------------------
            var numberOfTaxResolvers = taxResolver.Count();
            Assert.AreEqual(5, numberOfTaxResolvers);

        }

        [TestMethod]
        public void Given_RegisterTaxCalculator_When_Id_Does_Exist_ShouldNot_AddTaxCalculator()
        {
            //------------Setup---------------------------------
            var taxCalculator = new FlatRateTaxCalculatorRules(new Mock<IIncomeValidatorService>().Object);
            const string identifier = "Flat Rate";
            var taxResolver = new PostalCodeTaxResolverManager(new Mock<IIncomeValidatorService>().Object);
            taxResolver.RegisterTaxCalculator(identifier, taxCalculator);
            //------------Execute--------------------------------
            taxResolver.RegisterTaxCalculator(identifier, taxCalculator);
            //------------Assert--------------------------------
            var numberOfTaxResolvers = taxResolver.Count();
            Assert.AreEqual(5, numberOfTaxResolvers);

        }


    }
}


