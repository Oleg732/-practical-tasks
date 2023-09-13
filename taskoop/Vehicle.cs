using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskoop
{
    public class Vehicle
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }
        public Transmission transmission { get; set; }
        public Chassis Chassis { get; set; }

    }
}
