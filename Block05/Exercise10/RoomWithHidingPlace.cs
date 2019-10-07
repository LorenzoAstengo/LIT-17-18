using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise09;

namespace Exercise10
{
    public class RoomWithHidingPlace : Room,IHidingPlace
    {
        public string NameOfTheHidingPlace { get; private set; }

        public RoomWithHidingPlace(string name,string decoration, string hidingPlaceName) : base(name,decoration)
        {
            NameOfTheHidingPlace = hidingPlaceName;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + NameOfTheHidingPlace + ".";
            }
        }
    }
}
