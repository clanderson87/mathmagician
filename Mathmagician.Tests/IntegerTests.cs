using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTests
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            Integer my_int = new Integer();
            //if red squiggly, check if you have a class in the main project. Also check accessibility levels if squigs persist.
            Assert.IsNotNull(my_int);
            //creating an instance, and ensure it's not null. This is step one / sanity check.
        }

        [TestMethod]
        public void IntegerEnsureICanGetFirstNumber()
        {
            //Arrange : section 1. Scenario setup
            Integer my_int = new Integer();

            //Act: Section 2. do the thing you wanna test
            int actual = my_int.GetFirst();
            int expected = 0;

            //Assert: section 3. Did it work as expected?
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EnsureICanGetNextInteger()
        {
            //Arrange
            Integer my_int = new Integer();
            //Act
            int actual = my_int.GetNext(5);
            int expected = 6;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntegerEnsureICanCreateASequenceOfTenIntegers()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            int[] actual = my_int.GetSequence(10);
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IntegerEnsureMaxIsNotExceeded()
        {
            //Arrange
            Integer my_int = new Integer();

            //Act
            int[] actual = my_int.GetSequence(my_int.MAX+1);

            //Assert

            //below uses an older testing framework
            //Assert.Throws(typeof(Exception), my_int.GetSequence(my_int.MAX));
        }
    }
}
