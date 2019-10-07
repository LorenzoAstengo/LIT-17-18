namespace Exercise01
{
    public class PrivateProperty
    {
        protected string location;
        protected bool inCity;
        protected decimal estimatedValue;

        public PrivateProperty(string location, bool inCity, decimal value)
        {
            this.location = location;
            this.inCity = inCity;
            this.estimatedValue = value;
        }

        public PrivateProperty(string location)
            : this(location, true, 1000000)
        {
        }

        public string Location
        {
            get
            {
                return location;
            }
        }
    }
}
