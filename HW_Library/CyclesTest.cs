using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using Library;
using NUnit.Framework;



namespace Library.Test
{
    public class CyclesTest
    {
        [TestCase(2, 2, 4)]
        
            public void GetDegreeABTest(int a, int b, long exspected)
        {

            long actual = Cycles.GetDegreeAB(a, b);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(500, new int[] { 500, 1000 })]

        public void Split1000ATest(int a, int [] exspected)
        {
            int[] actual = Cycles.Split1000A(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(5, 2)]
        [TestCase(6, 2)]
        public void TypeNumbGetNumbCoreATest(int a, int exspected)
        {
            int actual = Cycles.TypeNumbGetNumbCoreA(a);
            Assert.AreEqual(exspected, actual);
        }
        [TestCase(10, 5)]
        public void TypeNumbGetMaxDelTest(int a, int exspected)
        {
            int actual = Cycles.TypeNumbGetMaxDel(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(2, 15, 21)]
        public void GetSumWhoDel7Test(int a, int b, int exspected)
        {
            int actual = Cycles.GetSumWhoDel7(a, b);
            Assert.AreEqual(exspected, actual);
        }
        [TestCase(3, 2)]
        public void GetFibonachiNumbTest(int n, int exspected)
        {
            int actual = Cycles.GetFibonachiNumb(n);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(3, 2, 1)]
        public void GetresultAlgorithmEvklidaTest(int a, int b, int exspected)
        {
            int actual = Cycles.GetresultAlgorithmEvklida(a, b);
            Assert.AreEqual(exspected, actual);

        }
        [TestCase (8,2)]
        public void GetresultHalfdDvisionTest (int a, int exspected)
        {
            int actual = Cycles.GetresultHalfdDvision (a);
            Assert.AreEqual(exspected, actual);
        }
        [TestCase(23,1)]
        public void FindQuantityOddNumbTest (int a,int exspected)
        {
            int actual = Cycles.FindQuantityOddNumb (a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(123,321)]

        public void FindMirrowNumbTest (int a, int exspected)
        {
            int actual = Cycles.FindMirrowNumb (a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase (4,0)]

        public void GetQuantitySummOddNuTest (int a, int exspected)
        {
            int actual = Cycles.FindQuantityOddNumb(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(454, 3121, "NET")]
        public void FindSameNumbTest (int a, int b, string exspected)
        {
            string actual = Cycles.FindSameNumb(a,b);
            Assert.AreEqual(exspected, actual);
        }
    }
}
