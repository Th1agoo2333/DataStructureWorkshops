namespace Geometry.Backend;

public class Kite : Rhombus
{
    // Fields
    private double _b;

    // Constructors
    public Kite(string name, double a, double d1, double d2, double b)
        : base(name, a, d1, d2)
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
        return (D1 * D2) / 2;
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