using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebClient.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ITaxResolverService _taxResolver;
        public IndexModel(ApplicationDbContext context, ITaxResolverService taxResolver)
        {
           _context = context;
           _taxResolver = taxResolver;
            PostalCode = context.PostalCode.Select(a =>
                                 new SelectListItem
                                 {
                                     Value = a.Code,
                                     Text = a.Code
                                 }).ToList();
         }
        public List<SelectListItem> PostalCode { get; set; }
        public IList<UserTaxCalculation> UserCalculations { get; set; }
        [BindProperty]
        public UserTaxCalculation UserCalculation { get; set; }
        public void OnGet()
        {
            UserCalculations = _context.UserTaxCalculation.ToList();
        }
        public RedirectToPageResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                UserCalculations = UserCalculations = _context.UserTaxCalculation.ToList();
                return PageResult();
            }            
            var calculation = _taxResolver.GetTaxCalculator(UserCalculation.PostalCode).Calculate(UserCalculation.AnnualIncome);
            UserCalculation.Id = Guid.NewGuid();
            UserCalculation.CalculationDate = DateTime.Now;
            UserCalculation.TaxCalculation = calculation;
            _context.UserTaxCalculation.Add(UserCalculation);
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
        private RedirectToPageResult PageResult()
        {
            return PageResult();
        }
    }
}


