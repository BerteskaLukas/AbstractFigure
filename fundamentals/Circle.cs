using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class Circle:AbstractFigure
    {
        public Circle()
        {
            Console.WriteLine("Created Circle");
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
