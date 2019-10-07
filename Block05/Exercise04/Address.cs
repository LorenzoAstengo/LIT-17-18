using System;

namespace PrototypeExercise
{
    public class Address
    {
        public String Street { get; set; }  
        public String Town { get; set; }
        public String Country { get; set; }
        public String ZIPCode { get; set; }
        public override string ToString()
        {
            return string.Format("{0}, {1} - {2} ({3})", Street, ZIPCode, Town, Country);
        }

        public Address(string street, string town, string country, string zIPCode)
        {
            Street = street;
            Town = town;
            Country = country;
            ZIPCode = zIPCode;
        }

        public Address() { }
    }
}
