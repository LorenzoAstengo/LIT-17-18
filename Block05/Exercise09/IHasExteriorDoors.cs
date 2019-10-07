using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public interface IHasExteriorDoors
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
