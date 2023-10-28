using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{

    using System;

    public class Circle :Shape
    {
        public double Radius { get; set; }
        public string Color { get; set; }
        public bool Filled { get; set; }

        public Circle()
        {
            Radius = 10.0;
            Color = "green";
            Filled = true;
        }

        public Circle(double radius)
        {
            Radius = radius;
            Color = "green";
            Filled = true;
        }

        public Circle(double radius, string color, bool filled)
        {
            Radius = radius;
            Color = color;
            Filled = filled;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"Circle [Radius={Radius}, Color={Color}, Filled={Filled}]";
        }
    }


}
