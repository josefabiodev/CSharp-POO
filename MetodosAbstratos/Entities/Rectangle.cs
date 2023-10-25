using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosAbstratos.Entities
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public Rectangle()
        {            
        }

        public Rectangle(Color color, double widht, double hight)
            : base(color)
        {
            Width = widht;
            Hight = hight;
        }

        prublic override double Area()
        {
            return Width * Hight;
        }
    }
}