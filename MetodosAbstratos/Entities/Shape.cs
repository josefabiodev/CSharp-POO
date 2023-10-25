using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp-POO.MetodosAbstratos.Entities.Enums;

namespace MetodosAbstratos.Entities
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}