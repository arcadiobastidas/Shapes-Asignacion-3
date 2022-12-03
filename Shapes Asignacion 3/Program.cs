using Shapes_Asignacion_3;


var circle = new Circle();

var circle2 = new Circle();

circle.Radius = 20;
circle2.Radius = 10;

Console.WriteLine(circle.Area());

Console.WriteLine(circle.GetType());

Shapes[] shapes = { circle, circle2 };


foreach(Shapes shape in shapes)
{
    Console.WriteLine(shape);
}