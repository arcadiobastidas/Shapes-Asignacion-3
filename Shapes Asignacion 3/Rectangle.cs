public class Rectangle : TwoDimensionalShapes
{
    private double length;
    private double width;

    //default constructor
    public Rectangle() : base()
    {
        length = 0;
        width = 0;
    }

    //parameter constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    /// <summary>
    /// Calculating area of a rectangle
    /// </summary>
    /// <returns> area</returns>
    public override double Area()
    {
        double area = length * width;
        return area;
    }


    public override void Ask()
    {
        try
        {
            Console.WriteLine($"{GetType()} details:\n");
            Console.Write("\tEnter length of rectangle: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("\tEnter width of rectangle: ");
            width = double.Parse(Console.ReadLine());

            if (length <= 0 || width <= 0)
            {
                Console.WriteLine("Length or Width can't be 0 or negative!");
                Ask();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number!");
            Ask();
        }
    }

    /// <summary>
    /// returns formatted result.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return String.Format(" This shape is a {0} and the Area is {1:n}", GetType(), Area());
    }
}