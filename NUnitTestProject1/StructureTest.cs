using System;
using System.Collections.Generic;
using System.Text;
using Library;
using NUnit.Framework;

namespace Library.Test
{
   public  class StructureTest
    {
        [TestCase(7, 6, 13)]

        public void ResultAMoreEqualsLessBTest(int a, int b, int exspected)
        {
            int actual = Structure.ResultAMoreEqualsLessB(a, b);
            Assert.AreEqual(exspected, actual);
        }
        [TestCase(7, 6, 4)]
        public void PointofCoordinateTest(int x, int y, int exspected)
        {
            int actual = Structure.PointofCoordinate(x, y);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(7, 6, 2, "2, 6, 7")]
        public void ABCAscendingOrderTest (int a, int b, int c, string exspected)
        {
            string actual = Structure.ABCAscendingOrder (a, b, c);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(1, 1, 2, new double[0])]
        public void SquareEquationResultTest(double a, double b, double c, double[] exspected)
        {
            double[] actual = new double[2];
            actual = Structure.SquareEquationResult (a, b, c);
              Assert.AreEqual(exspected, actual);
        }

        [TestCase(11, "Одиннадцать")]
        public void PrescriptionCountTest (int a, string  exspected)
        {
          string actual = Structure.PrescriptionCount(a);
          Assert.AreEqual(exspected, actual);
        }
    }
}

