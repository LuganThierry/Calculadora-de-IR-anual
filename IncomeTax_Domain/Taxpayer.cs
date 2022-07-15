using System;
namespace IncomeTax_Domain
{
    public class Taxpayer
    {

        public double AnnualIncome { get; set; }

        public Taxpayer()
        {
        }

        public Taxpayer(double annualIncome)
        {
            AnnualIncome = annualIncome;
        }
    }
}