using Microsoft.VisualStudio.TestTools.UnitTesting;
using VisualProgLab3test;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConvert()
        {
            RomanNumber value1 = new RomanNumber(8);
            RomanNumber value2 = new RomanNumber(33);
            RomanNumber value3 = new RomanNumber(74);
            RomanNumber value4 = new RomanNumber(347);
            RomanNumber value5 = new RomanNumber(2235);

            Assert.AreEqual("VIII", value1.ToString());
            Assert.AreEqual("XXXIII", value2.ToString());
            Assert.AreEqual("LXXIV", value3.ToString());
            Assert.AreEqual("CCCXLVII", value4.ToString());
            Assert.AreEqual("MMCCXXXV", value5.ToString());
        }

        [TestMethod]
        public void TestCorrectValue()
        {
            try
            {
                var value1 = new RomanNumber(1);
            }
            catch (RomanNumberException exep)
            {
                Assert.Fail(exep.Message);
            }

            try
            {
                var value2 = new RomanNumber(3999);
            }
            catch (RomanNumberException exep)
            {
                Assert.Fail(exep.Message);
            }
        }

        [TestMethod]
        public void TestIncorrectValue()
        {
            try
            {
                var c = new RomanNumber(0);
                Assert.Fail("Ошибка вводимого значения");
            }
            catch
            {
            }

            try
            {
                var d = new RomanNumber(4000);
                Assert.Fail("Ошибка вводимого значения");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void TestAdd()
        {
            var value1 = new RomanNumber(35);
            var value2 = new RomanNumber(100);
            Assert.AreEqual("CXXXV", (value1 + value2).ToString());
        }

        [TestMethod]
        public void TestSub()
        {
            var value1 = new RomanNumber(15);
            var value2 = new RomanNumber(5);
            Assert.AreEqual("X", (value1 - value2).ToString());
        }

        [TestMethod]
        public void TestMul()
        {
            var value1 = new RomanNumber(30);
            var value2 = new RomanNumber(5);
            Assert.AreEqual("VI", (value1 / value2).ToString());
        }

        [TestMethod]
        public void TestDiv()
        {
            var value1 = new RomanNumber(3);
            var value2 = new RomanNumber(5);
            Assert.AreEqual("XV", (value1 * value2).ToString());
        }

        [TestMethod]
        public void TestClone()
        {
            var value1 = new RomanNumber(67);
            var value2 = new RomanNumber(35);
            var CloneValue = (RomanNumber)value1.Clone();
            Assert.AreEqual(value1.ToString(), CloneValue.ToString());
            value1 = value2;
            Assert.AreNotEqual(value1.ToString(), CloneValue.ToString());
        }

        [TestMethod]
        public void TestCompare()
        {
            var a = new RomanNumber(3);
            var b = new RomanNumber(3);
            Assert.AreEqual(0, a.CompareTo(b));
            a += b;
            Assert.AreEqual(3, a.CompareTo(b));
        }
    }
}
