using NUnit.Framework;
using Library;

namespace Library.Test
{
    public class PeremenTest
    {
        [TestCase(2, 2, 5)]

        public void Soluthion1Test(int a, int b, int exspected)
        {
            int actual = Peremen.Soluthion1(a, b);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(2, 3,"3,2")]
        public void ReverseTest(int a, int b, string exspected)
        {

            string actual = Peremen.Reverse(a, b);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(3, 2, new int[2] {1,1})]
        public void GetResultandRestofDivisionTest(int a, int b, int[] exspected)
        {

            int[] actual = Peremen.GetResultandRestofDivision(a, b);
            Assert.AreEqual(exspected, actual);
        }

        [TestCase(1, 2, 3, 1)]
        public void ResaltXLineLevelTest(int a, int b, int Ò, double exspected)
        {
            double actual = Peremen.ResaltXLineLevel(a, b, Ò);
            Assert.AreEqual(exspected, actual);

        }
        [TestCase(0, 0, 1, 1, "ŒÚ‚ÂÚ y = -1x + 0")]
        public void —oordinatorsLineLevelTest(int x1, int y1, int x2, int y2, string exspected)
        {
            string actual = Peremen.—oordinatorsLineLevel(x1, y1, x2, y2);
            Assert.AreEqual(exspected, actual);
        }
    }
}
