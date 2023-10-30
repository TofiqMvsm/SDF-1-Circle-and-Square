using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STDF
{
   
    public class Square :Rectangle 
    {
        public double side;
       
       

        public Square(double side=10,string color="green", bool filled=true)
        {

            this.side = side;
            this.color = color;
            this.filled = filled;
        }



        public override string ToString()
        {
            return $"Square [Side={side}, Color={color}, Filled={filled}]";
        }
    }

}
