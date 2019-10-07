using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class MyComplex
    {
        private double real;
        public double Real
        {
            get { return real; }
            set { real = value; }
        }
        private double imaginary;
        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public MyComplex()
        {
            real = 0.0;
            imaginary = 0.0;
        }

        public MyComplex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public void SetValue(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override string ToString()
        {
            string x = Convert.ToString(real);
            string y = Convert.ToString(imaginary);
            string myComplex = "(" + x + "+" + y + "i)";
            return myComplex;
        }

        public bool IsReal()
        {
            if (real != 0 && imaginary == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsImaginary()
        {
            if (imaginary != 0 && real == 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(double real, double imag)
        {
            if(this.real==real && imaginary == imag)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(MyComplex another)
        {
            if(real==another.real && imaginary == another.imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Magnitude()
        {
            double res = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
            return res;
        }

        public double Argument()
        {
            double res = Math.Atan2(imaginary, real);
            return res;
        }

        public MyComplex Add(MyComplex right)
        {
            real = real + right.real;
            imaginary = imaginary + right.imaginary;
            return this;
        }

        public MyComplex Subtract(MyComplex right)
        {
            real = real - right.real;
            imaginary = imaginary - right.imaginary;
            return this;
        }

        public MyComplex Multiply(MyComplex right)
        {
            double precReal = real;
            real = (real * right.real)-(imaginary * right.imaginary);
            imaginary = (imaginary * right.real) + (precReal * right.imaginary);
            return this;
        }

        public MyComplex Divide(MyComplex right)
        {
            real = ((real * right.real) + (imaginary * right.imaginary)) / ((Math.Pow(right.real, 2) + Math.Pow(right.imaginary, 2)));
            imaginary = ((imaginary * right.real) + (real * right.imaginary)) / ((Math.Pow(right.real, 2) + Math.Pow(right.imaginary, 2)));
            return this;
        }

        public MyComplex Conjugate()
        {
            imaginary = -imaginary;
            return this;
        }

        //Operartors

        public static bool operator ==(MyComplex z1, MyComplex z2)
        {
            if ((z1.real == z2.real) &&
            (z1.imaginary == z2.imaginary))
                return (true);
            else
                return (false);
        }

        public static bool operator !=(MyComplex z1, MyComplex z2)
        {
            return (!(z1 == z2));
        }        

        public static MyComplex operator +(MyComplex z1, MyComplex z2)
        {
            return (new MyComplex(z1.real + z2.real, z1.imaginary + z2.imaginary));
        }

        public static MyComplex operator -(MyComplex z1, MyComplex z2)
        {
            return (new MyComplex(z1.real - z2.real, z1.imaginary - z2.imaginary));
        }

        public static MyComplex operator *(MyComplex z1, MyComplex z2)
        {
            return (new MyComplex(z1.real * z2.real - z1.imaginary * z2.imaginary, z1.real * z2.imaginary + z2.real * z1.imaginary));
        }

        public static MyComplex operator /(MyComplex z1, MyComplex z2)
        {
            if ((z2.real == 0.0D) &&
            (z2.imaginary == 0.0D))
                throw new DivideByZeroException("Can't divide by zero MyComplex number");

            double newReal = (z1.real * z2.real + z1.imaginary * z2.imaginary) / (z2.real * z2.real + z2.imaginary * z2.imaginary);
            double newimag = (z2.real * z1.imaginary - z1.real * z2.imaginary) / (z2.real * z2.real + z2.imaginary * z2.imaginary);

            return (new MyComplex(newReal, newimag));
        }

        public override bool Equals(object o2)
        {
            MyComplex z1 = (MyComplex)o2;

            return (this == z1);
        }

        public override int GetHashCode()
        {
            return (real.GetHashCode() ^ imaginary.GetHashCode());
        }
    }
}
