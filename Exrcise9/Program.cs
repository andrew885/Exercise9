using System;
using ClassLibrary1;

namespace Exrcise9
{
    class Program
    {
        static void Main(string[] args)
        {          
            MyCollection<Transport> transport = new MyCollection<Transport>();            
            transport.Add(new Transport(new Car("Tesla", 140)));
            transport.Add(new Transport(new Car("Lada", 90)));
            transport.Add(new Transport(new Boat("Titanik", 60)));
            transport.Add(new Transport(new Car("Ledokol", 20)));

            int index = 90;
            var item = transport[index];            
            if (item == null)
                Console.WriteLine("Index out of range");
            else
                Console.WriteLine($"Transport: {item.Name} speed is {item.Speed}");

            Console.WriteLine($"Array length: {transport.Count}");
        }
    }
}
