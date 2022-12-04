public class Circle : TwoDimensionalShapes
{
    private double radius;

    //default constructor
    public Circle() : base()
    {
    }
    //parameter constructor
    public Circle(double radius)
    {
        this.radius = radius;
    }
    //mutator for radius
    public double Radius
    {
        get { return radius; }
        set
        {
            if (radius >= 0)
            {
                radius = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("value");
            }
        }
    }

    //calculating area of a circule
    public override double Area()
    {
        double area = Math.PI * Math.Pow(Radius, 2);

        return area;
    }


    
    public override void Ask()
    {
        try
        {
            Console.WriteLine($"{GetType()} details:\n");
            Console.Write("\tEnter radius of circle: ");
            radius = double.Parse(Console.ReadLine());

            if (radius <= 0)
            {
                Console.WriteLine("Radius can't be 0 or negative!");
                Ask();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number!");
            Ask();
        }
    }

    //returning formatted results
    public override string ToString()
    {
        return String.Format("This is a {0} shape of type {1} and the Area is {2:n}", Type(), GetType(), Area());
    }
}