﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Geometry;
 public class Triangle : Rectangle

{
    private double _c;
    private double _h;

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    public double C 
    { 
        get => _c; set => _c = ValidateC(value); 
    }
    public double H 
    { 
        get => _h; set => _h = ValidateH(value); 
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }
    public override double GetPerimeter()
    {
        return (A + B + C);
    }

    private double ValidateC(double C)
    {
        return C > 0 ? C : throw new ArgumentOutOfRangeException("Value must be greater than zero.");
    }

    private double ValidateH(double H)
    {
        return H > 0 ? H : throw new ArgumentOutOfRangeException("Value must be greater than zero.");
    }
}
