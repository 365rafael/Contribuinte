using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuinte.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealtExpenditures { get; set; }

        public Individual(double healtExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealtExpenditures = healtExpenditures;
        }

        

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
            return (AnualIncome * 0.15)-(HealtExpenditures * 0.5);

            }
            else
            {
                return (AnualIncome * 0.25) - (HealtExpenditures * 0.5);
            }
        }
    }
}
