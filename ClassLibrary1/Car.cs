using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
