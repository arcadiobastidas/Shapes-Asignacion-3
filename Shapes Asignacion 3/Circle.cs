using Shapes_Asignacion_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Circle:TwoDimensionalShapes
    {
        private double radius;

   
        public Circle():base()
        {
           
        }

        public double Radius
        {
            get { return radius; }
            set
            {
                if(radius >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value");
                }
            }
        }


        public override double Area()
        {
            double area = Math.PI * Math.Pow(Radius, 2);

            return area;

        }

    }

