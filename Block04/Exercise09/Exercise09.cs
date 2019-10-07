using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public struct Time
    {
        public int minutes;
        public Time(int hh, int mm)
        {
            minutes = 60 * hh + mm;
        }
        public Time(int minutes)
        {
            this.minutes = minutes;
        }

        public int Hour
        {
            get
            {
                return minutes / 60;
            }
        }
        public int Minute
        {
            get
            {
                return minutes % 60;
            }
        }
        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}",Hour,Minute);
        }

        public static Time operator +(Time t1, Time t2)
        {
            Time res = new Time(t1.minutes + t2.minutes);
            return res;
        }

        public static Time operator -(Time t1, Time t2)
        {
            Time res = new Time(t1.minutes - t2.minutes);
            return res;
        }

        static public implicit operator Time(int minutes)
        {
            return new Time(minutes);
        }

        static public explicit operator int(Time time)
        {
            return time.minutes;
        }        
    }
    /*Is illegal to declare a non static field of tipe Time in Time cause struct are not allowed to be base classes to other types
     * and because C# does not allow structs to have initializers, instead of a class that it can.
     * I can declare a static field Noon of Time type in Time struct.
     * I've tried to change minutes to public and it gave me a wrong result.*/
}
