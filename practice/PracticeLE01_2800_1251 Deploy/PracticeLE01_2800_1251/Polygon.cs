using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLE01_2800_1251
{
    // complete the Polygon class as directed

    public class Polygon
    {
        private readonly int _sides = 0;
        private readonly double _radius = 0;

        public Polygon (int sides, double radius)
        {
            if (sides > 2)
                _sides = sides;
            else
                throw new ArgumentException("Polygon must have more than 2 sides!");

            if (radius > 0)
                _radius = radius;
            else
                throw new ArgumentException("radius must be greater than zero");
        }

        // add an indexer that accepts an int and returns a tuple (double, double)
        // the indexer will accept a vertex position (0 to the number of sides - 1)
        // the indexer will return the vertex position as (X, Y) for that vertex
        //  factoring in the vertex radius of the polygon
        // this can be computed with Cos(angle of vertex) * radius for X and
        //                           Sin(angle of vertex) * radius for Y
        // where the angle of the vertex is ((2 * Pi) / sides) * vertex index
        // throw an exception if the index is out of bounds
        // note the rounding in the sample test code
    }
}
