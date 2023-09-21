using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Bird : IFlyable
    {
        public int FlyTime { get; internal set; }
        public Coordinate Position { get; internal set; } = new Coordinate() { X = 0 };
        public int Speed { get; internal set; } = (new Random()).Next(0, 20);

        public void FlyTo(Coordinate coordinate)
        {
            Position.X = coordinate.X;
        }

        public int GetFlyTime(Coordinate coordinate)
        {
            if (Speed == 0) 
            {
                return 0;

            }

            return ((coordinate.X - Position.X) / Speed);
        }
    }
}
