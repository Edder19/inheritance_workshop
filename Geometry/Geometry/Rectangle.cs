using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;

    public class Rectangle : Square
{
    private double _b;
    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }
    public double B
    {
        get => _b;
        private set => _b = ValidateB(value);
    }

    

    public override double GetArea()
    {
        return A * B;
    }

    public override double GetPerimeter()
    {
         return 2 * (A + B);
    } 
    

    private static double ValidateB(double b)
    {
        return b > 0 ? b : throw new ArgumentException("Side B must be positive.");
    }
}

