using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public interface ITaxable
    {
        decimal TaxValue();
    }
    
    public class TaxableBus : Bus,ITaxable
    {
        public TaxableBus(int numberOfSeats, int regNumber, decimal value) :
            base(regNumber, 80, value)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public decimal TaxValue()
        {
            decimal tax = value * 20 / 100;
            return tax;
        }
    }

    public class TaxableHouse : House,ITaxable
    {
        public TaxableHouse(string location, bool inCity, double area, decimal value) : base(location, inCity, area, value)
        {
            this.area = area;
        }

        public decimal TaxValue()
        {
            decimal tax = (estimatedValue * 15 / 100) + (Convert.ToDecimal(area * 2 / 100));
            return tax;
        }
    }
}
