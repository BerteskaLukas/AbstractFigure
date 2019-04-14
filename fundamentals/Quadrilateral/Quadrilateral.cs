using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class Quadrilateral : AbstractFigure
    {
        private readonly AnglePoint[] anglePoints;

        public Quadrilateral()
        {
            anglePoints = new AnglePoint[4];
        }

        public Quadrilateral(double angle, double edgeBefore, double edgeAfter,
            double angleInfront, double edgeBeforeInfront, double edgeAfterInfront) : this()
        {
            anglePoints[0] = new AnglePoint(angle, edgeBefore, edgeAfter);
            anglePoints[2] = new AnglePoint(angleInfront, edgeBeforeInfront, edgeAfterInfront);
            double hypotenuse = FormulaLibrary.OpositeEdge(anglePoints[0]);
            double secondAngle = FormulaLibrary.AngleBetween(angle, hypotenuse, edgeAfter) + FormulaLibrary.AngleBetween(angleInfront, hypotenuse, edgeAfterInfront);
            double lastAngle = 360 - angle - angleInfront - secondAngle;
            anglePoints[1] = new AnglePoint(secondAngle, edgeAfter, edgeBeforeInfront);
            anglePoints[3] = new AnglePoint(lastAngle, edgeAfterInfront, edgeBefore);
        }
        public Quadrilateral(double edge):this() // Square constructor
        {
            anglePoints[0] = new AnglePoint(90, edge, edge);
            anglePoints[1] = new AnglePoint(90, edge, edge);
            anglePoints[2] = new AnglePoint(90, edge, edge);
            anglePoints[3] = new AnglePoint(90, edge, edge);
        }
        public Quadrilateral(double edgeBefore,  double edgeAfter) : this()
        {
            anglePoints[0] = new AnglePoint(90, edgeBefore, edgeAfter);
            anglePoints[1] = new AnglePoint(90, edgeAfter, edgeBefore);
            anglePoints[2] = new AnglePoint(90, edgeBefore, edgeAfter);
            anglePoints[3] = new AnglePoint(90, edgeAfter, edgeBefore);
        }



        public override double Area()
        {
            double s = Perimeter() * 0.5;

            return Math.Sqrt(
                     (s - anglePoints[0].EdgeBefore) * (s - anglePoints[0].EdgeAfter) * (s - anglePoints[2].EdgeBefore) * (s - anglePoints[2].EdgeAfter) -
                     anglePoints[0].EdgeBefore * anglePoints[0].EdgeAfter * anglePoints[2].EdgeBefore * anglePoints[2].EdgeAfter *
                     Math.Cos(((anglePoints[0].Angle + anglePoints[2].Angle) / 2) * Math.PI / 180) * Math.Cos(((anglePoints[0].Angle + anglePoints[2].Angle) / 2) * Math.PI / 180));
        }

        public override double Perimeter()
        {
            return anglePoints.Aggregate(0.0, (total, edgePoint) => total + edgePoint.EdgeBefore);
        }
    }
}
