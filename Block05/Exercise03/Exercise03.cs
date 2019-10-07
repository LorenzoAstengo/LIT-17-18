using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class TriBool
    {
        public enum States { True,False,Indeterminate};
        private States state;
        public States State
        {
            get { return state; }
            set { state = value; }
        }

        public static implicit operator TriBool(bool a)
        {
            if (a == true)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static explicit operator bool(TriBool a)
        {
            if (a.state == States.True)
                return true;
            else if (a.state == States.False)
                return false;
            else
                throw new InvalidOperationException();
        }

        public static TriBool operator ==(TriBool a, TriBool b)
        {
            if (a.state == b.state)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static TriBool operator !=(TriBool a, TriBool b)
        {
            if (a.state != b.state)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static TriBool operator !(TriBool a)                   
        {
            if (a.state == States.True)
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
            else if (a.state == States.False)
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
            else
                return a;
        }

        public static TriBool operator &(TriBool a, TriBool b)                   
        {
            if (a.state == b.state)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else 
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static TriBool operator |(TriBool a, TriBool b)          
        {
            if (a.state == States.True | b.state==States.True)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static TriBool operator ^(TriBool a, TriBool b)
        {
            if (a.state == States.True && b.state != a.state)
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public static TriBool NAND(TriBool a,TriBool b)
        {
            if (a.state == States.True && b.state == States.True)
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
        }

        public static TriBool NOR(TriBool a, TriBool b)
        {
            if (a.state == (States.False | States.Indeterminate) && b.state == (States.False | States.Indeterminate))
            {
                TriBool res = new TriBool();
                res.state = States.True;
                return res;
            }
            else
            {
                TriBool res = new TriBool();
                res.state = States.False;
                return res;
            }
        }

        public bool isTrue()
        {
            if (this.state == States.True)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isFalse()
        {
            if (this.state == States.False)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isIndeterminate()
        {
            if (this.state == States.Indeterminate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator true(TriBool a)
        {
            if (a.state == States.True)
                return true;
            else
                return false;
        }

        public static bool operator false(TriBool a)
        {
            if (a.state == States.False)
                return true;
            else
                return false;
        }
        public override bool Equals(object o)
        {
            try
            {
                return (bool)(this.state == ((TriBool)o).state);
            }
            catch
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return state.GetHashCode();
        }
    }

    
}
