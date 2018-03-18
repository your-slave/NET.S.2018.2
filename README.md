# NET.S.2018.Karakouski.2

1. Two integer signed four byte numbers and two bit positions i and j (i <j) are given. Implement InsertNumber insertion algorithm of inserting bits from the jth to the i-th bit of one number into another so that the bits of the second number occupy positions from bit j to bit i (bits are numbered from right to left). Develop unit tests (NUnit and (!) MS Unit Test) to test the method. (Below is an explanation to the algorithm).
2. Implement the FindNextBiggerNumber method, which takes a positive integer and returns the nearest largest integer consisting of the digits of the original number, and null (or -1), if such a number does not exist.
o Develop unit tests (NUnit or MS Unit Test) to test the method. Exemplary test cases
 [TestCase (12, ExpectedResult = 21)]
 [TestCase (513, ExpectedResult = 531)]
 [TestCase (2017, ExpectedResult = 2071)]
 [TestCase (414, ExpectedResult = 441)]
 [TestCase (144, ExpectedResult = 414)]
 [TestCase (1234321, ExpectedResult = 1241233)]
 [TestCase (1234126, ExpectedResult = 1234162)]
 [TestCase (3456432, ExpectedResult = 3462345)]
 [TestCase (10, ExpectedResult = -1)]
 [TestCase (20, ExpectedResult = -1)]
o Add to the FindNextBiggerNumber method the ability to return the time of finding a given number, considering various language features. Develop unit tests (NUnit or MS Unit Test) to test the method.
3. Implement the FilterDigit method that takes an array of integers and filters it so that only numbers containing the specified digit remain on the output (LINQ requests do not use!) For example, for the digit 7, FilterDigit (7,1,2,3, 4,5,6,7,68,69,70, 15,17) -> {7, 7, 70, 17}. Develop unit tests (NUnit and MS Unit Test (including the DDT approach)) for testing the method.
