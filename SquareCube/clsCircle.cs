using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCube
{
    class clsCircle
    {
        decimal decRadius = 0m;

        public clsCircle()
        {
            decRadius = 0m;
        }

        public clsCircle(decimal decRad)
        {
            if (decRad > 0m)
            {
                decRadius = decRad;
            }
        }

        public decimal Radius
        {
           get
           {
               return decRadius;
           }
           set
           {
               if (value >= 0M)
               {
                   decRadius = value;
               }
           }
        }

        public decimal Circumference()
        {
            return 2 * (decRadius * Convert.ToDecimal(Math.PI));
        }
        public decimal Area()
        {
            return Convert.ToDecimal(Math.PI) * (decRadius * decRadius);
        }
        public virtual String Definition()
        {
            return "Circle: Circumference and Area";
        }
    }

}
