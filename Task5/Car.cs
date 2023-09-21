using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task5
{
    
    [Serializable]
    public class Car : Vehicle
    {
        public Car()
        {
            Name = "Легковой Автомобиль";
        }
    }
}
