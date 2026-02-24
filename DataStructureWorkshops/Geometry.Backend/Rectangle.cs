namespace Geometry.Backend;

public class Rectangle : Square
{
    // Fields
    private double _b;

    // Constructors
    public Rectangle(string name, double a, double b)
        : base(name, a)
    {
        B = b;
    }

    // Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Methods
    public override double GetArea()
    {
        return A * _b;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + _b);
    }

    // Validate
    private double ValidateB(double b)
    {
        if (b <= 0)
        {
            throw new Exception("Side B must be greater than zero.");
        }

        return b;
    }
}