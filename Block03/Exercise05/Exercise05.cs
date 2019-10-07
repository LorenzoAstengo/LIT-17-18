using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatingAndUsingObjects;

namespace Exercise05
{
    public class CreateCats
    {
        public static Cat[] Create()
        {
            Sequence.Reset();
            Cat[] cats = new Cat[10];
            for(int i = 0; i < cats.Length; i++)
            {
                Cat a = new Cat("Cat"+Convert.ToString(Sequence.NextValue()),"Gray");
                cats[i] = a;
            }
            return cats;
        }        
    }
}
