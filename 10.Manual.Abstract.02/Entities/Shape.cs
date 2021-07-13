using System;
using System.Collections.Generic;
using System.Text;
using Entities.Enums;
namespace Entities {
    abstract class Shape {
        public Color Color { get; set; }
        protected Shape(Color color) {
            Color = color;
        }
        public abstract double Area();
    }
}
