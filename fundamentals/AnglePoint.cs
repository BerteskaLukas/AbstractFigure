using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    public class AnglePoint
    {
        private double angle;
        private double edgeAfter;
        private double edgeBefore;

        public AnglePoint(double angle, double edgeBefore, double edgeAfter)
        {
            Angle = angle;
            EdgeAfter = edgeAfter;
            EdgeBefore = edgeBefore;
           
        }

        public double Angle
        {
            get { return angle; }
            set
            {
                if (value < 0 || value > 360)
                    throw new ArgumentException();

                angle = value;

            }
        }



        public double EdgeBefore
        {
            get { return edgeBefore; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                edgeBefore = value;
            }
        }



        public double EdgeAfter
        {
            get { return edgeAfter; }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                edgeAfter = value;
            }
        }




    }
}
