public class Cube : ThreeDimensionalShapes
{
    private double side;

    //default constructor
    public Cube() : base()
    {
        this.side = 0;
    }

    //parameter constructor
    public Cube(double side)
    {
        this.side = side;
    }

    //radius mutator
    public double Radius
    {
        get { return side; }
        set
        {
            if (side >= 0)
            {
                side = value;
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
            Console.Write("\tEnter lenght of a side of the Cube: ");
            side = double.Parse(Console.ReadLine());

            if (side <= 0)
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

    //Calculating volume of Cube
    public override double Volume()
    {
        double volume = Math.Pow(side, 3);

        return volume;
    }

    //returning results
    public override string ToString()
    {
        return String.Format(" This shape is a {0} and the volume is {1:F2}", GetType(), Volume());
    }
}