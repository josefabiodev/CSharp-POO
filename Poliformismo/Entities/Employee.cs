using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poliformismo.Entities
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public int Hours {get; set;}
        public double ValuePerHour { get; set; }

        public Employee()
        {            
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}