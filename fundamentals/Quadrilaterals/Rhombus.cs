using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class Rhombus:Quadrilateral
    {
        public Rhombus(double angle, double edge) 
           
        {
                anglePoints[0] = new AnglePoint(angle, edge, edge);
                anglePoints[1] = new AnglePoint((360 - 2 * angle) / 2, edge, edge);
                anglePoints[2] = new AnglePoint(angle, edge, edge);
                anglePoints[3] = new AnglePoint((360 - 2 * angle) / 2, edge, edge);
        }
        

    }
}
