using NET.S._2018.Karakouski._2;
using NUnit.Framework;
using System;

namespace NET.S._2018.Karakouski.NUnit.Tests
{
    [TestFixture]
    public class DataManipulatorTests
    {
        [TestCase]
        public void InsertNumber_IndenticalInputNumbersIdenticalPositions_TheSameNumber()
        {
            Assert.AreEqual(DataManipulator.InsertNumber(15, 15, 0, 0), 15);
        }

        [TestCase]
        public void InsertNumber_InsertingNumbersDifferentOneBitAtChangingPosition_DiffrentNumber()
        {
            Assert.AreEqual(DataManipulator.InsertNumber(8, 15, 0, 0), 9);
        }

        [TestCase]
        public void InsertNumber_InsertingNumbermbersDifferentWithNumberOfBitsBitAtChangingPosition_DiffrentNumber()
        {
            Assert.AreEqual(DataManipulator.InsertNumber(8, 15, 3, 8), 120);
        }

        [TestCase]
        public void InsertNumber_IIsGreaterThanJ_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DataManipulator.InsertNumber(8, 15, 8, 3));
        }


        [TestCase]
        public void InsertNumber_IncorrectI_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DataManipulator.InsertNumber(8, 15, 33, 54));
        }

        [TestCase]
        public void FilterDigit_CollectionsContainingFilteredNumber_FilteredCollection()
        {
            int[] testData = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            CollectionAssert.AreEquivalent(new int[] { 7, 7, 70, 17 }, DataManipulator.FilterDigit(testData, 7));

        }

        [TestCase]
        public void FilterDigit_NullCollection_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DataManipulator.FilterDigit(null, 7));
        }

        [TestCase]
        public void FilterDigit_EmptyCollection_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => DataManipulator.FilterDigit(new int[0], 7));
          }

        [TestCase]
        public void FilterDigit_NotDigitAsFilteringInput_ArgumentException()
        {
            int[] testData = new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            Assert.Throws<ArgumentException>(() => DataManipulator.FilterDigit(testData, 47));
        }
    }

}

