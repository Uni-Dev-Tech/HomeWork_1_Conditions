using System;
using System.Linq;

namespace conditionsPractice
{
    public class ConditionPracticeClass
    {
        /*TODO: The method must receive one parameter of the int type as input - a number to check.
        The method must return a boolean value, depending on whether the input parameter is even or odd*/
        public static bool IsEven(int number)
        {
            int result = number %= 2;
            return result == 0 ? true : false;
        }

        /* TODO: Receives a string as input and returns true if the string contains 
         * only unique characters, false otherwise. */
        public static bool HasUniqueCharacters(string input)
        {
            Char[] characters = input.ToCharArray();
            for(int i = 0; i < characters.Length; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (Equals(characters[i], characters[j]))
                        return false;
                }
            }

            return true;
        }

        /* TODO: Receives an integer as input and returns true if the number is 
         * divisible by both 5 and 7, excluding zero, false otherwise. */
        public static bool IsDivisibleBy5And7(int number)
        {
            if (number == 0) return false;

            int fiveDivision = number % 5;
            int sevenDivision = number % 7;

            if (fiveDivision == 0 && sevenDivision == 0) return true;
            return false;
        }

        /* TODO: Performs the specified arithmetic operation (char input paramether) 
         * on two double input paramethers and returns the result. */
        public static double PerformOperation(char operation, double number1, double number2)
        {
            switch (operation)
            {
                case '+': return number1 + number2;
                case '-': return number1 - number2;
                default: return 0;
            }
        }

        /* TODO: Receives an integer as input and returns "Positive" if the number is positive,
         * "Negative" if the number is negative, "Zero" if the number is zero. */
        public static string CheckNumber(int number)
        {
            if (number > 0) return "Positive";
            else if (number < 0) return "Negative";
            else return "Zero";
        }

        /* TODO: Receives a string as input and returns true if the string is a palindrome,
         * false otherwise. */
        public static bool IsPalindrome(string input)
        {
            var chs = input.ToCharArray();
            Array.Reverse(chs);
            string reversed = new string(chs);
            if (Equals(reversed, input)) return true;
            else return false;
        }

        /* TODO: Receives a int year as input paramether and returns true if the year is a leap year,
         * false otherwise. */
        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0) return true;
                    else return false;
                }
                else return true;
            }
            else return false;
        }


        /* TODO: Receives a character as input and returns true if the character is a vowel, 
         * false otherwise. */
        public static bool IsVowel(char character)
        {
            character = char.ToUpper(character);

            switch (character)
            {
                case 'A': return true;
                case 'E': return true;
                case 'I': return true;
                case 'O': return true;
                case 'U': return true;
                case 'Y': return true;
                default: return false;
            }
        }

        /* TODO: Converts a binary number represented as a string to its integer equivalent. */
        public static int BinaryToDecimal(string binaryNumber)
        {
            throw new NotImplementedException();
        }

        /* TODO: Converts a binary number represented as a string to its hexadecimal string equivalent. */
        public static string BinaryToHexadecimal(string binaryNumber)
        {
            throw new NotImplementedException();
        }
    }
}
