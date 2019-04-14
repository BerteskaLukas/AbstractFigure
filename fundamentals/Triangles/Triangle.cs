using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class Triangle:AbstractFigure
    {
        private readonly AnglePoint[] anglePoints;

        public Triangle()
        {
            anglePoints = new AnglePoint[3];
        }

        public Triangle(double angle, double edgeBefore, double edgeAfter) : this() // konstruktorius belekokiame trikampiui
        {
            
            anglePoints[0] = new AnglePoint(angle, edgeBefore, edgeAfter);
            double a = FormulaLibrary.OpositeEdge(anglePoints[0]);
            double B = FormulaLibrary.AngleBetween(angle, a, edgeBefore);
            double C = 180 - B - angle;
            anglePoints[1] = new AnglePoint(B,  edgeAfter, a);
            anglePoints[2] = new AnglePoint(C, a, edgeBefore);

        }

        protected Triangle(double edge):this() // konstruktorius lygiakrasciam
        {
            
            anglePoints[0] = new AnglePoint(60, edge, edge);
            anglePoints[1] = new AnglePoint(60, edge, edge);
            anglePoints[2] = new AnglePoint(60, edge, edge);

        }

        protected Triangle(double angle, double edge):this() // konstruktorius lygiasoniam 
        {
            anglePoints[0] = new AnglePoint(angle, edge, edge);
            double A = (180 - angle) / 2;
            double B = A;
            double c = FormulaLibrary.OpositeEdge(anglePoints[0]);
            anglePoints[1] = new AnglePoint(A, edge, c );
            anglePoints[2] = new AnglePoint(B, c, edge);

        }


        

        public override double Area()
        {
            return 0.5 * Math.Sin(anglePoints[0].Angle*Math.PI / 180)
                *anglePoints[0].EdgeBefore * anglePoints[0].EdgeAfter;
        }

        public override double Perimeter()
        {
            //Linq
            // var leftAngles = anglePoints.Where(ap => ap.Angle < 90);
            
            return anglePoints.Aggregate(0.0, (total, edgePoint) => total + edgePoint.EdgeBefore );// iteruojami objektai ir kaip juos susumuoti
          
        }
    }
}
