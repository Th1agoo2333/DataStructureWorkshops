namespace Geometry.Backend;

public class Rhombus : Square
{
    // Fields
    private double _d1;
    private double _d2;

    // Constructors
    public Rhombus(string name, double a, double d1, double d2)
        : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // Properties
    public double D1
    {
        get => _d1;
        set => _d1 = ValidateD1(value);
    }

    public double D2
    {
        get => _d2;
        set => _d2 = ValidateD2(value);
    }

    // Methods
    public override double GetArea()
    {
        return (_d1 * _d2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    // Validate
    private double ValidateD1(double d1)
    {
        if (d1 <= 0)
        {
            throw new Exception("Diagonal D1 must be greater than zero.");
        }

        return d1;
    }

    private double ValidateD2(double d2)
    {
        if (d2 <= 0)
        {
            throw new Exception("Diagonal D2 must be greater than zero.");
        }

        return d2;
    }
}