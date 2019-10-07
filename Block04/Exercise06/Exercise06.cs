using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    public class MyPolinomial
    {
        private double[] coeffs;
        public double[] Coeffs
        {
            get { return coeffs; }
            set { coeffs = value; }
        }

        public MyPolinomial(params double[] coeffs)
        {
            this.coeffs = new double[coeffs.Length];
            for(int a = 0; a < coeffs.Length; a++) 
            {
                this.coeffs[a] = coeffs[a];
            }
        }

        public int GetDegree()
        {
            int degree = coeffs.Length - 1;
            return degree;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for(int i = coeffs.Length - 1 ; i >= 0; i--)
            {
                if (i != 0)
                {
                    builder.Append(coeffs[i] + "x^" + (i) + " + ");
                }
                else
                {
                    builder.Append(coeffs[i]);
                }
            }
            string res = builder.ToString();
            return res;
        }

        public double Evaluate(double x)
        {
            double res = 0;
            for(int i = coeffs.Length - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    res = res + (coeffs[i] * Math.Pow(x, i));
                }
                else
                {
                    res = res + coeffs[i];
                }                                              
            }
            return res;
        }

        public MyPolinomial Add(MyPolinomial polinomial)
        {
            int k = 0;
            if (coeffs.Length >= polinomial.coeffs.Length)
            {
                for (int i = 0; i < coeffs.Length; i++)
                {
                    if (k != polinomial.coeffs.Length)
                    {
                        coeffs[i] = coeffs[i] + polinomial.coeffs[k];
                        k++;
                    }
                    else
                    {
                        coeffs[i] = coeffs[i];
                    }
                }
                return this;
            }
            else
            {
                double[] prevCoeffs = coeffs;
                coeffs = new double[polinomial.coeffs.Length];
                for(int i = 0; i < polinomial.coeffs.Length; i++)
                {
                    if (i != prevCoeffs.Length)
                    {
                        coeffs[i] = prevCoeffs[i] + polinomial.coeffs[i];
                    }
                    else
                    {
                        coeffs[i] = polinomial.coeffs[i];
                    }                    
                }
                return this;
            }                     
        }

        public MyPolinomial Multiply(MyPolinomial polinomial)
        {
            int m = coeffs.Length;
            int n = polinomial.coeffs.Length;
            double[] res = new double[m + n - 1];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    res[i + j] += coeffs[i] * polinomial.coeffs[j];
            }
            coeffs = res;
            return this;
        }
    }    
}
