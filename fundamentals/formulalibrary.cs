using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
   public static  class FormulaLibrary
    {
        //pagal kosinuso teorema
        public static double OpositeEdge( AnglePoint anglePoint)
        {
            return Math.Sqrt(Math.Pow(anglePoint.EdgeBefore, 2) + Math.Pow(anglePoint.EdgeAfter, 2)
               - 2 * anglePoint.EdgeBefore * anglePoint.EdgeAfter * Math.Cos(anglePoint.Angle * Math.PI / 180));
        }


        //pagal sinususu teorema
        public static double AngleBetween(double knowAngle, double knowEdege, double oppositeEdge)
        {
            return Math.Asin(Math.Sin(knowAngle * Math.PI / 180) * knowEdege / oppositeEdge);
        }
    }
}
