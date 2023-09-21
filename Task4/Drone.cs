using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Drone : IFlyable
    {
        public int FlyTime { get; internal set; }
        public Coordinate Position { get; internal set; } = new Coordinate() { X = 0 };
        public int Speed { get; internal set; } = 50;

        public void FlyTo(Coordinate coordinate)
        {
            var distance = coordinate.X - Position.X;

            if (distance > 1000)
            {
                Position.X = 1000;
            }
            else
            {
                Position.X = coordinate.X;
            }
        }


        //дрон зависает в воздухе
        //    каждые 10 минут полета на 1 минуту. Исходя из задачи, 

        public int GetFlyTime(Coordinate coordinate)
        {
            var distance = (coordinate.X - Position.X);

            var dis = (Speed / 60) * 10; //км за 10 мин 8.3

            var time = 0;

            while (distance != 0) 
            {
                distance = distance - dis;

                if (distance < 0)
                {
                    distance = 0;
                }
                else
                {
                    if (distance < dis)
                    {
                        time += (distance / Speed);
                    }
                    else
                    {
                        time += 10;

                        time += 1;
                    }
                }

            }

            return time ;
        }
    }
}
