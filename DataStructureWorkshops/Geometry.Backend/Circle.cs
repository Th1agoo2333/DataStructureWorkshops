namespace Geometry.Backend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;

    // Constructor
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Methods
    public override double GetArea()
    {
        return Math.PI * _r * _r;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * _r;
    }

    // Validate
    private double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new Exception("The radius must be greater than zero.");
        }

        return r;
    }
}