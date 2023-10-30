using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
    public class Shape
    {
        public string color;
        public bool filled; 

    
        public Shape(string color="green", bool filled=true)
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
