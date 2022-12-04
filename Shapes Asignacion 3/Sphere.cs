public class Sphere : ThreeDimensionalShapes
{
    private double radius;

    //declaring default contructor
    public Sphere() : base()
    {
    }

    //default parameter constructor
    public Sphere(double radius)
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
                throw new ArgumentException("Radius can't be negative");
            }
        }
    }

    public override void Ask()
    {
        try
        {
            Console.WriteLine($"{GetType()} details:\n");
            Console.Write("\tEnter radius of a Sphere: ");
            radius = double.Parse(Console.ReadLine());

            if (radius <= 0)
            {
                Console.WriteLine("Side lenght can't be 0 or negative!");
                Ask();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number!");
            Ask();
        }
    }

    //Calculating volume of a sphere
    public override double Volume()
    {
        double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);

        return volume;
    }

    //Calculating surface area of a sphere
    public override double Area()
    {
        double area = 4 * Math.PI * Math.Pow(radius, 2);

        return area;
    }

    //returning results. 
    public override string ToString()
    {
        return String.Format(" This shape is a {0}, the volume is {1:F2} and the area is {2:F2}", GetType(), Volume(), Area());
    }
}