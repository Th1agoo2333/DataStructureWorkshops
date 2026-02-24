namespace Geometry.Backend;

public abstract class GeometricFigure
{
    // Fields
    private string _name = string.Empty;

    // Constructors
    public GeometricFigure(string name)
    {
        _name = name;
    }

    // Properties
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    // Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area......: {GetArea(),12:N5}    Perimeter: {GetPerimeter(),12:N5}";
    }
}