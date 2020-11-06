using System;
using System.Collections.Generic;
using System.Text;
using Library;
using NUnit.Framework;

namespace Library.Test
{
    public class MassTest
    {
        [TestCase(new int[] { 1, 2, 3 }, 3)]

        public void MaxElementArrayTest(int[] a, int exspected)
        {
            int actual = Mass.MaxElementArray(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 1)]

        public void MinElementArrayTest(int[] a, int exspected)
        {
            int actual = Mass.MinElementArray(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 0)]
        public void MinIndexElementArrayTest(int[] a, int exspected)
        {
            int actual = Mass.MinIndexElementArray(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]
        public void MaxIndexElementArrayTest(int[] a, int exspected)
        {
            int actual = Mass.MaxIndexElementArray(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 2)]

        public void GetSummOddElementOfMassTest(int[] a, int exspected)
        {
            int actual = Mass.MaxIndexElementArray(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        public void GetReserveMassTest(int[] a, int [] exspected)
        {
            int [] actual = Mass.GetReserveMass (a);
            Assert.AreEqual(exspected, actual);

        }
        [TestCase(new int[] { 4, 2, 3 }, 1)]
        public void GetNubOddElementMassTest (int[] a, int exspected)
        {
            int actual = Mass.GetNubOddElementMass(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1,2 })]
        public void ReserveHalfOfMassTest (int[] a, int[] exspected)
        {
            int[] actual = Mass.ReserveHalfOfMass(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 6, 3, 1, 8 }, new int[] { 8, 6, 3, 1 })]
        public void SelectSortMassTest (int[] a, int[] exspected)
        {
            int[] actual = Mass.SelectSortMass(a);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(new int[] { 6, 3, 1, 8 }, new int[] { 1, 3, 6, 8 })]
        public void BubbleSortMassTest(int[] a, int[] exspected)
        {
            int[] actual = Mass.BubbleSortMass(a);
            Assert.AreEqual(exspected, actual);
        }

    }
}
