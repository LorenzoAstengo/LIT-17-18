using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class CountOfWorkDays
    {
        static public DateTime[] holidays = new DateTime[] {
            new DateTime(DateTime.Now.Year, 1, 1),
            new DateTime(DateTime.Now.Year, 1, 6),
            new DateTime(DateTime.Now.Year, 4, 25),
            new DateTime(DateTime.Now.Year, 5, 1),
            new DateTime(DateTime.Now.Year, 6, 1),
            new DateTime(DateTime.Now.Year, 8, 15),
            new DateTime(DateTime.Now.Year, 11, 1),
            new DateTime(DateTime.Now.Year, 12, 8),
            new DateTime(DateTime.Now.Year, 12, 25),
            new DateTime(DateTime.Now.Year, 12, 26)
            };

        public static int WorkDays(DateTime date1, DateTime date2)
        {    
            int diffDays = Convert.ToInt32((date2 - date1).TotalDays + 1);
            while (date1 <= date2)
            {
                if (date1.DayOfWeek == DayOfWeek.Saturday || date1.DayOfWeek == DayOfWeek.Sunday)
                {
                    diffDays--;
                }
                else if (holidays.Contains(date1))
                {
                    diffDays--;
                }
                date1 = date1.AddDays(1);
            }            
            return diffDays;
        }
    }
}
