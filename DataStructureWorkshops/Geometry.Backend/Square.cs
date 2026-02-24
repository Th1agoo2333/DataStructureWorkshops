namespace Geometry.Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Methods
    public override double GetArea()
    {
        return _a * _a;
    }

    public override double GetPerimeter()
    {
        return 4 * _a;
    }

    // Validate
    private double ValidateA(double a)
    {
        if (a <= 0)
        {
            throw new Exception("Side A must be greater than zero.");
        }

        return a;
    }
}