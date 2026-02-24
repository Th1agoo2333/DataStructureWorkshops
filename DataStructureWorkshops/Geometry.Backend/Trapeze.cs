namespace Geometry.Backend;

public class Trapeze : Triangle
{
    // Fields
    private double _d;

    // Constructors
    public Trapeze(string name,
                   double a,
                   double b,
                   double c,
                   double d,
                   double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    // Properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    // Methods
    public override double GetArea()
    {
        return ((B + _d) * H) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + _d;
    }

    // Validate
    private double ValidateD(double d)
    {
        if (d <= 0)
        {
            throw new Exception("Side D must be greater than zero.");
        }

        return d;
    }
}