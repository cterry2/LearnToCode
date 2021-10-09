using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.ComplexFunctions;
using System.Collections.Generic;

namespace UnitTests.BasicFunctions
{
    [TestClass]
    public class ComplexFunctionsTests
    {
        private string[] fruitArray1 = new string[] { "orange", "cherry", "orange", "strawberry" };
        private string[] fruitArray2 = new string[] { "orange", "cherry", "orAnge", "strawberry", null };
        private string[] fruitArray3 = new string[] { "apple", "cherry", "orange2", "strawberry" };

        private List<int?> numberList1 = new List<int?>() { 1, 2, 3, 4, 5, 6, 7 };
        private List<int?> numberList2 = new List<int?>() { 1, 2, null, 4, null, 6, 7 };

        [TestMethod]
        public void TestReturnMaxNumberEmpty()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var max = func.ReturnMaxNumber(new List<int>());

            Assert.AreEqual(max, 0);
        }

        [TestMethod]
        public void TestReturnMaxNumber()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var array = new List<int> { 1, 2, 3, 4 };
            var max = func.ReturnMaxNumber(array);

            Assert.AreEqual(max, 4);
        }

        [TestMethod]
        public void TestReturnMaxNumberOutOfOrder()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();
            var array = new List<int> { 1, 20, 3, 4 };
            var max = func.ReturnMaxNumber(array);

            Assert.AreEqual(max, 20);
        }

        [TestMethod]
        public void TestReturnMaxNumberNull()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var max = func.ReturnMaxNumber(null);

            Assert.AreEqual(max, 0);
        }

        [TestMethod]
        public void TestAddFourItemsToArrayNull()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.AddFourItemsToArray(null);

            Assert.AreEqual(newList.Count, 4);
        }

        [TestMethod]
        public void TestReturnAllOranges1()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.ReturnAllOranges(fruitArray1);

            Assert.AreEqual(newList.Count, 2);
        }

        [TestMethod]
        public void TestReturnAllOranges2()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.ReturnAllOranges(fruitArray2);

            Assert.AreEqual(newList.Count, 2);
        }

        [TestMethod]
        public void TestReturnAllOranges3()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.ReturnAllOranges(fruitArray3);

            Assert.AreEqual(newList.Count, 1);
        }

        [TestMethod]
        public void TestSortListAscending()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.SortListAscending(fruitArray1);

            Assert.AreEqual(newList[0], "cherry");
            Assert.AreEqual(newList[1], "orange");
            Assert.AreEqual(newList[2], "orange");
            Assert.AreEqual(newList[3], "strawberry");
        }

        [TestMethod]
        public void TestSortListAscendingNull()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.SortListAscending(fruitArray2);

            Assert.AreEqual(newList[0], "cherry");
            Assert.AreEqual(newList[1], "orAnge");
            Assert.AreEqual(newList[2], "orange");
            Assert.AreEqual(newList[3], "strawberry");
        }

        [TestMethod]
        public void TestSortListDescendingNull()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.SortListDescending(fruitArray2);

            Assert.AreEqual(newList[3], "cherry");
            Assert.AreEqual(newList[2], "orAnge");
            Assert.AreEqual(newList[1], "orange");
            Assert.AreEqual(newList[0], "strawberry");
        }

        [TestMethod]
        public void TestSortListDescending()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var newList = func.SortListDescending(fruitArray1);

            Assert.AreEqual(newList[3], "cherry");
            Assert.AreEqual(newList[2], "orange");
            Assert.AreEqual(newList[1], "orange");
            Assert.AreEqual(newList[0], "strawberry");
        }

        [TestMethod]
        public void TestAverageAList()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var average = func.AverageAList(numberList1);

            Assert.AreEqual(average, 4.0);
        }

        [TestMethod]
        public void TestAverageAListNull()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var average = func.AverageAList(numberList2);

            Assert.AreEqual(average, 2.857);
        }

        [TestMethod]
        public void TestUnderstandSideEffects()
        {
            var func = new ConsoleApp.ComplexFunctions.Functions();

            var word = "test";
            func.UnderstandSideEffects(word);

            Assert.AreNotEqual(word, "test");
        }
    }
}