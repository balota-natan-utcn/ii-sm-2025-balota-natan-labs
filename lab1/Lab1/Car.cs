using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Car
    {
        public String Name;
        public int EnginePower;
        public decimal Price;

        public Car(string name, int enginePower, decimal price)
        {
            Name = name;
            EnginePower = enginePower;
            Price = price;
        }

        public static int compareCars(Car car1, Car car2)
        {
            // Compare by engine power in descending order (higher is better)
            int powerComparison = car2.EnginePower.CompareTo(car1.EnginePower);
            if (powerComparison != 0)
                return powerComparison;

            // If power is the same, compare by price in ascending order (lower is better)
            return car1.Price.CompareTo(car2.Price);
        }

        public override string ToString()
        {
            return $"{Name} - Power: {EnginePower} HP, Price: ${Price}";
        }
    }
}
