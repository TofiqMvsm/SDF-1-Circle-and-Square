using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
    public class Shape
    {
        public string color { get; set; }
        public bool filled { get; set; }

        public Shape()
        {
            color = "green";
            filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public virtual string ToString()
        {
            return "This is a base class";
        }
    }
}
