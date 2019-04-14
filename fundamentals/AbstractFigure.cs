using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public abstract class AbstractFigure
    {

        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.Append("Area: " + Area() + "\n");
            sb.Append("Perimeter: " + Perimeter() + "\n");
            return sb.ToString();
        }

    }


}
