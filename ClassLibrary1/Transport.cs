using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Transport
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Transport(Car car)
        {
            Name = car.Name;
            Speed = car.Speed;
        }
        public Transport(Boat boat)
        {            
            Name = boat.Name;
            Speed = boat.Speed;            
        }
    }
}
