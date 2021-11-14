using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Boat
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public Boat(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }
}
