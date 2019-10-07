using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Robot
    {
        private int x;
        private int y;
        public enum Directions { N, E, S, W };
        private Directions direction;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public Directions Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }

        }
        public Robot()
        {
        }
        public Robot(int x, int y, Directions direction)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
        }

        public void Move(int x, int y, char directionInserted, string movements)
        {
            bool isADirection = Enum.TryParse<Directions>(Convert.ToString(directionInserted), out Directions direction);
            if (isADirection)
            {
                for (int i = 0; i < movements.Length; i++)
                {
                    switch (movements[i])
                    {
                        case 'R':
                            direction++;
                            break;
                        case 'L':
                            direction--;
                            break;
                        case 'A':
                            switch (Convert.ToInt16(direction))
                            {
                                case 0:
                                    y++;
                                    break;
                                case 1:
                                    x++;
                                    break;
                                case 2:
                                    x--;
                                    break;
                                case 3:
                                    y--;
                                    break;
                            }
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
