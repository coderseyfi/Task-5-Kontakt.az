using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartphone_1
{
    class Iphones
    {
        public int id;
        public string name;
        public string producer;
        public string type;
        public string bluetoothVersion;
        public string color;
        public int price;
        public int memory;
        public int cores;
        public int year;
        public int weight;

       static int counter = 0;
        public Iphones()
        {
            counter++;
            id = counter;
        }

        public override string ToString()
        {
            return $"No: {id}\n" +
                $"Name: {name}\n" +
                $"Type: {type}\n" +
                $"Bluetooth Version: {bluetoothVersion}\n" +
                $"Color: {color}\n" +
                $"Price: {price}\n" +
                $"Memory: {memory}\n" +
                $"Cores: {cores}\n" +
                $"Year: {year}\n" +
                $"Weight: {weight}\n";
        }
    }
}
