using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise09;

namespace Exercise10
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string NameOfTheHidingPlace { get; private set; }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            NameOfTheHidingPlace = hidingPlaceName;
        }
    }
}
