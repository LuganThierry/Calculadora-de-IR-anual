using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IncomeTax_Domain;


namespace IncomeTax_Services.Interfaces
{
    public interface ITaxCalculator
    {
        public double TaxCalculationMethod(double value);
    }
}
