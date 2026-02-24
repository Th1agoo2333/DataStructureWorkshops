namespace Geometry.Backend;

public class Triangle : Rectangle
{
    // Fields
    private double _c;
    private double _h;

    // Constructors
    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Methods
    public override double GetArea()
    {
        return (B * _h) / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + _c;
    }

    // Validate
    private double ValidateC(double c)
    {
        if (c <= 0)
        {
            throw new Exception("Side C must be greater than zero.");
        }

        return c;
    }

    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception("Height must be greater than zero.");
        }

        return h;
    }
}