using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
    public class Rectangle :Shape
    {
        private double width { get; set; }
        private double length { get; set; } 


        public Rectangle(double width=1.0, double length = 1.0, string color="green", bool filled=true)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;
        }

      

     

        public double GetArea()
        {
            return width * length;
        }

        public double GetPerimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            return $"Rectangle [width={width}, length={length}, color={color}, filled={filled}]";
        }
    }
}
