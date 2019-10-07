using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExercise
{
    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - Address: {3}", Name, Role, PreferredLanguage, Address);
        }
        public override Employee Clone()
        {
            /*return this.MemberwiseClone() as Employee;*/
            Employee empClone = this.MemberwiseClone() as Employee;
            if (this.Address != null)
            {
                empClone.Address = new Address(Address.Street, Address.Town, Address.Country, Address.ZIPCode);
            }
            return empClone;

        }
    }
}
