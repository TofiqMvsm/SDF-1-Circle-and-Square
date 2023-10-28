using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
    public class Rectangle :Shape
    {
        private double width;
        private double length;
        private string color;
        private bool filled;

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
            color = "green";
            filled = true;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
            color = "green";
            filled = true;
        }

        public Rectangle(double width, double length, string color, bool filled)
        {
            this.width = width;
            this.length = length;
            this.color = color;
            this.filled = filled;
        }

        public double GetWidth()
        {
            return width;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetLength()
        {
            return length;
        }

        public void SetLength(double length)
        {
            this.length = length;
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
