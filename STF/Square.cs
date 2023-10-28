using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
   
    public class Square :Rectangle 
    {
        public double Side { get; set; }
        public string Color { get; set; }
        public bool Filled { get; set; }
        public double Radius { get; internal set; }

        public Square()
        {
            Side = 1.0;
            Color = "green";
            Filled = true;
        }

        public Square(double side, string color, bool filled)
        {
            Side = side;
            Color = color;
            Filled = filled;
        }



        public override string ToString()
        {
            return $"Square [Side={Side}, Color={Color}, Filled={Filled}]";
        }
    }

}
