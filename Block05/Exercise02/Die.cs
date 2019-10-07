using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{   

    public class Die : IComparable<Die>
    {
        public delegate void twoSixesInARowEventHandler();
        public event twoSixesInARowEventHandler twoSixesInARow;

        public delegate void fullHouseEventHandler();
        public event fullHouseEventHandler fullHouse;

        private int number;
        static private Random randomNumberSupplier = new Random((int)DateTime.Now.Ticks);
        private const int maxNumberOfEyes = 6;
        private List<int> numbers;

        public Die()
        {
            numbers = new List<int>();
            number = NewToss();
        }

        public void Toss()
        {
            number = NewToss();
            numbers.Add(number);
            TwoSixesInARow(numbers);
            FullHouse(numbers);
        }

        protected virtual void TwoSixesInARow(List<int> numbers)
        {
            if (twoSixesInARow != null)
            {
                if (numbers.Count >= 2)
                {
                    if (numbers[numbers.Count - 1] == 6 &&
                           numbers[numbers.Count - 2] == 6)
                        twoSixesInARow();
                }
            }
        }

        protected virtual void FullHouse(List<int> numbers)
        {
            if (fullHouse != null)
            {
                if (numbers.Count >= 5)
                {
                    List<int> full = new List<int>();
                    for (int i = 0; i < 5; i++)
                    {
                        full.Add(numbers[numbers.Count - 1 - i]);
                    }
                    for (int i = 0; i <= 4; i++)
                    {
                        int counter = 0;
                        for (int j = 0; j <= 4; j++)
                        {
                            if (full[i] == full[j])
                                counter++;
                        }
                        if (counter == 3)
                        {
                            for (int k = 0; k <= 4; k++)
                            {
                                int counter2 = 0;
                                for (int f = 0; f <= 4; f++)
                                {
                                    if (full[k] == full[f] && full[k] != full[i])
                                        counter2++;
                                }
                                if (counter2 == 2)
                                    fullHouse();
                                else
                                    counter2 = 0;
                            }
                        }
                        else
                            counter = 0;
                    }
                }
            }
        }

        private int NewToss()
        {
            return randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
        }

        public int Number()
        {
            return number;
        }

        public override String ToString()
        {
            return String.Format("[{0}]", number);
        }

        public int CompareTo(Die die)
        {
            if (this.number == die.number)
                return 0;
            else if (this.number > die.number)
                return 1;
            else
                return -1;
        }
    }
}
