using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExercise
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public Address Address { get; set; }

        public abstract Employee Clone();
        public abstract override String ToString();
    }
}
