using IncomeTax_Domain;
using IncomeTax_Presentation.Interfaces;
using IncomeTax_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax_Presentation
{
    public class Layout : ILayout
    {
        private readonly ITaxCalculator _taxCalculator;

        public Layout(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void Taxpayer()
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual seus proventos anuais?");
            double AnnualIncome = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{nome}, o valor de IR devido é de R${_taxCalculator.TaxCalculationMethod(AnnualIncome)}");
        }
    }
}
