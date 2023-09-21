using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //IFlyable с методами FlyTo(новая точка), GetFlyTime(новая точка).
    public interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        int GetFlyTime(Coordinate coordinate);
        int FlyTime { get; }
        Coordinate Position { get; }
        int Speed { get; }
    }
}
