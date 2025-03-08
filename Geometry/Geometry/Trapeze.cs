using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;
public class Trapeze : Triangle
{
    private double _d;

    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        D = d;
    }

    public double D { get => _d; set => _d = ValidateD(value); }

    public override double GetArea()
    {
        return(B + D) * H / 2;
    }
    public override double GetPerimeter()
    {
        return A + B + C + D;
    }
    private double ValidateD(double D)
    {
        return D > 0 ? D : throw new ArgumentOutOfRangeException("Value must be greater than zero.");
    }
}
