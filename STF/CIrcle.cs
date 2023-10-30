using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{

    using System;

    public class Circle : Shape
    {
        public double radius;
        public Circle(double radius=10, string color = "Green", bool filled = true)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }

        public override string ToString()
        {
            return $"Circle [Radius={radius}, Color={color}, Filled={filled}]";
        }
    }


}
