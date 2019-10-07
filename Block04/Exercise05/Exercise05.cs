using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using BitIntegerExtension;

namespace Exercise05
{
    public class Interlocutor
    {
        private string name;
        public string Name
            {
                get { return name; }
                set { name = value; }
            }

        private BigInteger secretNumber;
        public BigInteger SecretNumber
        {
            get { return secretNumber; }
            set { secretNumber = value; }
        }

        public class DHKeyExcange
        {
            private BigInteger primeNumber;
            public BigInteger PrimeNumber
            {
                get { return primeNumber; }
                set { primeNumber = value; }
            }
            private BigInteger baseNumber;
            public BigInteger BaseNumber
            {
                get { return baseNumber; }
                set { baseNumber = value; }
            }

            public DHKeyExcange(BigInteger primeNumber, BigInteger baseNumber)
            {
                this.primeNumber = primeNumber;
                this.baseNumber = baseNumber;
            }
        }

        private DHKeyExcange dHKey;
        public DHKeyExcange DHKey
        {
            get { return dHKey; }
            set { dHKey = value; }
        }

        public Interlocutor(string name, BigInteger number, DHKeyExcange key)
        {
            this.name = name;
            dHKey = key;
            if (number >= 1 && number < dHKey.PrimeNumber)
            {
                secretNumber = number;
            }
            else
            {
                throw new ArgumentException();
            }            
        }        

        public BigInteger GeneratePublicKey()
        {
            BigInteger publicKey = dHKey.BaseNumber.CustomPow(secretNumber) % dHKey.PrimeNumber;
            return publicKey;
        }

        public BigInteger GenerateSecretKey(BigInteger publicKey)
        {
            BigInteger res = publicKey.CustomPow(secretNumber) % dHKey.PrimeNumber;
            return res;
        }        
    }    
}

namespace BitIntegerExtension
{
    public static class BitIntegerExtension
    {
        public static BigInteger CustomPow(this BigInteger a, BigInteger b)
        {
            BigInteger originalValue = a;
            while (b-- > 1)
                a = BigInteger.Multiply(a, originalValue);
            return a;
        }
    }
}
