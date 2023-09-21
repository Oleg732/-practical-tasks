using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Plane : IFlyable
    {
        public int FlyTime { get; internal set; }
        public Coordinate Position { get; internal set; } = new Coordinate() { X = 0 };
        public int Speed { get; internal set; } = 200;

        //    самолет увеличивает скорость на 10 км/ч каждые 10 км 
        //    полета от начальной скорости 200 км/ч.

        public void FlyTo(Coordinate coordinate)
        {
            Position.X = coordinate.X;
        }

        public int GetFlyTime(Coordinate coordinate)
        {
            var distance = coordinate.X - Position.X;

            if (distance <= 200)
            {
                return distance / Speed;
            }
            else
            {
                var left = distance - 200;

                var time = MakeTimeByDistance(left);

                return time;
            }
        }

        private int MakeTimeByDistance(double left) 
        {
            double time = left > 0 ? 60 : 0;

            while (left != 0) 
            {
                Speed += 10;

                time += (double)10 / Speed;

                left = left - (((double)time/60) * Speed);

                if (left < 0 )
                {
                    left = 0;
                }
            }

            return (int) time;
        }
    }
}
