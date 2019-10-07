using System;
using System.Collections;

namespace Exercise05
{
    public class Interval
    {
        private readonly int from, to;
        private int[] arr;

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public Interval(int from, int to)
        {
            this.from = from;
            this.to = to;
            arr = CreateIndex();
        }

        public int[] CreateIndex()
        {
            int[] index = new int[Length];
            if (from < to)
            {
                index[0] = from;
                for (int i = 1; i < Length; i++)
                {
                    index[i] = (index[i - 1]) + 1;
                }
            }
            else if (from > to)
            {
                index[0] = from;
                for (int i = 1; i < Length; i++)
                {
                    index[i] = (index[i - 1]) - 1;
                }
            }
            else
                index[0] = from;
            return index;
        }

        public int From
        {
            get { return from; }
        }

        public int To
        {
            get { return to; }
        }

        public int Length
        {
            get { return Math.Abs(to - from) + 1; }
        }

        public static Interval operator +(Interval i, int j)
        {
            return new Interval(i.From + j, i.To + j);
        }

        public static Interval operator +(int j, Interval i)
        {
            return new Interval(i.From + j, i.To + j);
        }

        public static Interval operator >>(Interval i, int j)
        {
            return new Interval(i.From, i.To + j);
        }

        public static Interval operator <<(Interval i, int j)
        {
            return new Interval(i.From + j, i.To);
        }

        public static Interval operator *(Interval i, int j)
        {
            return new Interval(i.From * j, i.To * j);
        }

        public static Interval operator *(int j, Interval i)
        {
            return new Interval(i.From * j, i.To * j);
        }

        public static Interval operator -(Interval i, int j)
        {
            return new Interval(i.From - j, i.To - j);
        }

        public static Interval operator !(Interval i)
        {
            return new Interval(i.To, i.From);
        }

        public static explicit operator int[] (Interval i)
        {
            int[] res = new int[i.Length];
            for (int j = 0; j < i.Length; j++)
                res[j] = i[j];
            return res;
        }

        private class IntervalEnumerator : IEnumerator
        {

            private readonly Interval interval;
            private int idx;

            public IntervalEnumerator(Interval i)
            {
                this.interval = i;
                idx = -1;   // position enumerator outside range
            }

            public Object Current
            {
                get
                {
                    return (interval.From < interval.To) ?
                             interval.From + idx :
                             interval.From - idx;
                }
            }

            public bool MoveNext()
            {
                if (idx < Math.Abs(interval.To - interval.From))
                { idx++; return true; }
                else
                { return false; }
            }

            public void Reset()
            {
                idx = -1;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new IntervalEnumerator(this);
        }
    }
}
