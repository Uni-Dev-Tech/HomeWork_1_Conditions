using conditionsPractice;

namespace conditionsPracticeTests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(-4, true)]
        [InlineData(101, false)]
        public void IsEven_WhenCalled_ReturnsExpectedResult(int number, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.IsEven(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("abcde", true)]
        [InlineData("hello", false)]
        [InlineData("world", true)]
        [InlineData("12345", true)]
        [InlineData("11a22b33c", false)]
        public void HasUniqueCharacters_ValidInput_ReturnsExpectedResult(string input, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.HasUniqueCharacters(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(35, true)]
        [InlineData(70, true)]
        [InlineData(10, false)]
        [InlineData(14, false)]
        [InlineData(105, true)]
        [InlineData(12, false)]
        [InlineData(0, false)]
        public void IsDivisibleBy5And7_ValidInput_ReturnsExpectedResult(int number, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.IsDivisibleBy5And7(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2, 3, '+', 5)]
        [InlineData(10, 5, '-', 5)]
        [InlineData(4, 6, '*', 24)]
        [InlineData(10, 2, '/', 5)]
        public void PerformOperation_ValidInput_ReturnsExpectedResult(double number1, double number2, char operation, double expectedResult)
        {
            // Act
            double result = ConditionPracticeClass.PerformOperation(operation, number1, number2);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, "Positive")]
        [InlineData(-10, "Negative")]
        [InlineData(0, "Zero")]
        public void CheckNumber_ValidInput_ReturnsExpectedResult(int number, string expectedResult)
        {
            // Act
            string result = ConditionPracticeClass.CheckNumber(number);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("level", true)]
        [InlineData("radar", true)]
        [InlineData("hello", false)]
        [InlineData("12321", true)]
        [InlineData("abcba", true)]
        public void IsPalindrome_ValidInput_ReturnsExpectedResult(string input, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.IsPalindrome(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(2000, true)]
        [InlineData(2004, true)]
        [InlineData(2008, true)]
        [InlineData(2012, true)]
        [InlineData(2100, false)]
        [InlineData(1900, false)]
        [InlineData(2018, false)]
        [InlineData(2022, false)]
        public void IsLeapYear_ValidInput_ReturnsExpectedResult(int year, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.IsLeapYear(year);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData('A', true)]
        [InlineData('E', true)]
        [InlineData('i', true)]
        [InlineData('O', true)]
        [InlineData('u', true)]
        [InlineData('b', false)]
        [InlineData('D', false)]
        [InlineData('z', false)]
        public void IsVowel_ValidInput_ReturnsExpectedResult(char character, bool expectedResult)
        {
            // Act
            bool result = ConditionPracticeClass.IsVowel(character);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("10", 2)]
        [InlineData("101", 5)]
        [InlineData("1100", 12)]
        [InlineData("11111", 31)]
        public void BinaryToDecimal_ValidInput_ReturnsExpectedResult(string binaryNumber, int expectedResult)
        {
            // Act
            int result = ConditionPracticeClass.BinaryToDecimal(binaryNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("0", "0")]
        [InlineData("1", "1")]
        [InlineData("10", "2")]
        [InlineData("101", "5")]
        [InlineData("1100", "C")]
        [InlineData("11111", "1F")]
        public void BinaryToHexadecimal_ValidInput_ReturnsExpectedResult(string binaryNumber, string expectedResult)
        {
            // Act
            string result = ConditionPracticeClass.BinaryToHexadecimal(binaryNumber);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}