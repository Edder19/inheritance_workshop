using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Geometry;
public class Square : GeometricFigure
{
    private double _a;

    public Square(string name, double a) : base(name)
    {
        
        A = a;
    }

    public double A 
    {
        get => _a; 
        set => _a = ValidateA(value);
    }
    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }
    private double ValidateA(double a)
    {
        return a > 0 ? a : throw new ArgumentOutOfRangeException("Value must be greater than zero.");
    }
}


