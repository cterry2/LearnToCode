using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.BasicFunctions;

namespace UnitTests.BasicFunctions
{
    [TestClass]
    public class BasicFunctionsTests
    {
        [TestMethod]
        public void TestReverseAStringEasy()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var reversed = func.ReverseAString("test");

            Assert.AreEqual(reversed, "tset");
        }

        [TestMethod]
        public void TestReverseAStringNull()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var reversed = func.ReverseAString(null);

            Assert.AreEqual(reversed, null);
        }

        [TestMethod]
        public void TestTellMeTheTypeInt()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var type = func.TellMeTheType(0);

            Assert.AreEqual(type, "Int32");
        }

        [TestMethod]
        public void TestTellMeTheTypeString()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var type = func.TellMeTheType("myType");

            Assert.AreEqual(type, "String");
        }

        [TestMethod]
        public void TestReturnMyGenericTypeString()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var type = func.ReturnGenericType("myType");

            Assert.AreEqual(type, "myType");
        }

        [TestMethod]
        public void TestReturnMyGenericTypeInt()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var type = func.ReturnGenericType(1);

            Assert.AreEqual(type, 1);
        }

        [TestMethod]
        public void TestCountMyStringTen()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var count = func.CountMyString("this string");

            Assert.AreEqual(count, 10);
        }

        [TestMethod]
        public void TestCountMyStringNull()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var count = func.CountMyString(null);

            Assert.AreEqual(count, 0);
        }

        [TestMethod]
        public void TestMyStringHasEvenLettersNull()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var success = func.MyStringHasEvenLetters(null);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void TestMyStringHasEvenLettersTrue()
        {
            var func = new ConsoleApp.BasicFunctions.Functions();         

            var success = func.MyStringHasEvenLetters("null");

            Assert.IsTrue(success);
        }
    }
}