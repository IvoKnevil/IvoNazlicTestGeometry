using Microsoft.VisualStudio.TestTools.UnitTesting;
using IvoNazlicTestGeometry.Tools;
using System;
using System.Collections.Generic;
using System.Text;
using IvoNazlicTestGeometry.GeometryObjects;

namespace IvoNazlicTestGeometry.Tools.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        [TestMethod()]
        public void GetCircumferenceTest()
        {
            var calc = new GeometricCalculator();
            var actual = calc.GetCircumference(new Interfaces.IGeometricThing[]
                {
                    new Square(1),
            });
                            
        }
    }
}