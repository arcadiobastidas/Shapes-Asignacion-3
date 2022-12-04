using Shapes_Asignacion_3;

//Intro to program

Console.Write("This program will ask the user the required\nvalues to calculate Area or Volume\nfor ");
Console.Write("Twodimensional and Threedimensional shapes.\n\n");

//Initializing objects
var circle = new Circle();
var rectangle = new Rectangle();
var sphere = new Sphere();
var cube = new Cube();

//Prompt user to enter required values for Twodimensional objects

Console.WriteLine("Enter information for Twodimensional objects: \n");
circle.Ask();
Console.WriteLine();
rectangle.Ask();

//Prompt user to enter required values for Thredimensional objects

Console.WriteLine("\nEnter information for Threedimensional objects: \n");
cube.Ask();
Console.WriteLine();
sphere.Ask();

//Initialize array of shapes
Shapes[] shapes = { circle, rectangle, cube, sphere };


Console.WriteLine("Results\n");
//Iterating array of shapes
//If Shape is twodimensional, the area will print to the console. Threedimensional shapes will print volume.
foreach (Shapes shape in shapes)
{
    if (shape.Type() == "TwoDimensionalShape") // using inheritance, here we invoke the Type of shape to filter out dimensinal shapes.
    {
        Console.WriteLine(shape.ToString());
    }
    else if (shape.Type() == "ThreeDimensionalShapes")
    {
        Console.WriteLine(shape.ToString());
    }
    else
        Console.WriteLine("Not an available shape.");
}