using IvoNazlicTestGeometry.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace IvoNazlicTestGeometry.GeometryObjects
{
    public class Square : IGeometricThing
    {
        public float Side { get; set; }

        public Square(float side)
        {
            Side = side;
        }

        public float GetArea()
        {
            return (float)Math.Pow(Side, 2);
        }

        public float GetCircumference()
        {

            return 4 * Side;
        }


    }
}
