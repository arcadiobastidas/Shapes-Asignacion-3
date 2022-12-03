using Shapes_Asignacion_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    //abstract class as base clase for circle and triangle
    public abstract class TwoDimensionalShapes:Shapes
    {
       
        public TwoDimensionalShapes() : base() 
        {    
            //default constructor
        }

        
        //creating abstract method to calculate area based on twodimensional figure
        public abstract double Area();
    }

