using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }  

        prublic override double Area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}