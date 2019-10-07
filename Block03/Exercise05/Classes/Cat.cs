using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingAndUsingObjects
{
    public class Cat
    {
        private string name;
        private string color;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        /*public Cat()
        {
            this.name = "Unnamed";
            this.color = "gray";
        }*/

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
