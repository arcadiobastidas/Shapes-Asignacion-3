using Shapes_Asignacion_3;

//abstract class as base clase for circle and triangle
public abstract class TwoDimensionalShapes : Shapes
{
    public TwoDimensionalShapes() : base()
    {
        //default constructor
    }

    //creating abstract method to calculate area based on twodimensional figure
    public abstract double Area();

    //Creating abstract Ask method to declare it in inherited twodimensinal shapes. 
    //this will be responsible of initializing the object.
    public abstract void Ask();

    //returning the type of figure
    public override string Type()
    {
        return "TwoDimensionalShape";
    }
}