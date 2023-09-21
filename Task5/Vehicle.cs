using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task5
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Bike))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]

    [Serializable]
    public class Vehicle
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Chassis Chassis { get; set; }

    }
}
