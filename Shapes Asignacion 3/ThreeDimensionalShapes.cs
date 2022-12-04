using Shapes_Asignacion_3;

public abstract class ThreeDimensionalShapes : Shapes
{
    public ThreeDimensionalShapes()
    {
    }

    //Creating abstract Ask method to declare it in inherited twodimensinal shapes. 
    //this will be responsible of initializing the object.
    public abstract void Ask();

    //creating abstract method to calculate volume based on threedimensinal figures
    public abstract double Volume();

    //returning the type of figure
    public override string Type()
    {
        return "ThreeDimensionalShapes";
    }
}