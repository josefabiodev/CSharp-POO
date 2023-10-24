using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poliformismo.Entities;

namespace Poliformismo.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }

        public OutsourcedEmployee()
        {            
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, addtionalCharge)
            : base(name, hours, valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return (Hours * ValuePerHour) + AddtionalCharge * 1.1;
        }
    }
}