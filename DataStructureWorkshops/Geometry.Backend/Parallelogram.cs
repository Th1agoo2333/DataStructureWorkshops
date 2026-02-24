namespace Geometry.Backend;

public class Parallelogram : Rectangle
{
    // Fields
    private double _h;

    // Constructors
    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = h;
    }

    // Properties
    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Methods
    public override double GetArea()
    {
        return B * _h;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    // Validate
    private double ValidateH(double h)
    {
        if (h <= 0)
        {
            throw new Exception("Height must be greater than zero.");
        }

        return h;
    }
}