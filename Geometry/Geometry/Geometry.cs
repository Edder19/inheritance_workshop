using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry;
public abstract class GeometricFigure
{
    public string Name { get; }

    

    protected GeometricFigure(string name)
    {
        Name = name;
    }


    public abstract double GetArea();

    public abstract double GetPerimeter();
    

    public override string ToString()
    {
        return $"{Name,-15} => Area......: {GetArea().ToString("#,##0.00000", CultureInfo.InvariantCulture),15}\t Perimeter: {GetPerimeter().ToString("#,##0.00000", CultureInfo.InvariantCulture),10}";
    }

}
