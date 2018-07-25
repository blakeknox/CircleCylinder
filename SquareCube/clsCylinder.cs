using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareCube
{
    class clsCylinder : clsCircle
    {
        decimal decHeight = 0m;

        //Construnctor
        public clsCylinder()
           : base()
        {
            decHeight = 0m;
        }

        public clsCylinder(decimal decRad, decimal decHgt)
            : base(decRad)
        {
            if (decHeight >= 0m)
            {
                decHeight = decHgt;
            }
        }
        public decimal Height
        {
            get
            {
                return decHeight;
            }
            set
            {
                if(value >= 0m)
                {
                    decHeight = value;
                }
            }
        }

        public decimal Volume()
        {
            return base.Area() * decHeight;
        }

        public override string Definition()
        {
            return "Cylinder Class: Circumference, Area, and Volume.";
        }

    }
}
