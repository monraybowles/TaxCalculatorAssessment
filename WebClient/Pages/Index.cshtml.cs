using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
        public IList<UserTaxCalculationDto> UserCalculations { get; set; }

        [BindProperty]
        public UserTaxCalculationDto UserCalculation { get; set; }
        public void OnGet()
        {
            UserCalculations = UserCalculations = _context.UserTaxCalculation.ToList();
        }

        public RedirectToPageResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                UserCalculations = UserCalculations = _context.UserTaxCalculation.ToList();
                return PageResult();
            }
           
            if (UserCalculation.PostalCode == "" || UserCalculation.EmailAddress == "")
            {
               
                return PageResult();
            }


            var x = UserCalculation.AnnualIncome;
             var y = UserCalculation.PostalCode.TrimEnd();
            //var calValuse = y
            //  var calculation = 4444;
           // double calculation;
            var calValue = _taxResolver.GetTaxCalculator(y).Calculate(x);
           // calculation.Calculate(calValue);
            UserCalculation.Id = Guid.NewGuid();
            UserCalculation.CalculationDate = DateTime.Now;
            UserCalculation.TaxCalculation = Convert.ToDouble(calValue);
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