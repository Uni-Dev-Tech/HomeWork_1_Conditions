using System;

namespace conditionsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IsEven
            Console.WriteLine("IsEven");
            var isEventValue = 2;
            bool resultIsEven = ConditionPracticeClass.IsEven(isEventValue);
            if (resultIsEven) Console.WriteLine($"{isEventValue} is even!");
            else Console.WriteLine($"{isEventValue} is not even!");

            SpaceAwait();

            // HasUniqueCharacters
            Console.WriteLine("HasUniqueCharacters");
            var hasUniqueCharactersValue = "Start";
            bool resultHasUniqueCharactersValue =
                ConditionPracticeClass.HasUniqueCharacters(hasUniqueCharactersValue);
            if (resultHasUniqueCharactersValue)
                Console.WriteLine($"{hasUniqueCharactersValue} has all unic characters!");
            else Console.WriteLine($"{hasUniqueCharactersValue} has not all unic characters!");

            SpaceAwait();

            // IsDivisibleBy5And7
            Console.WriteLine("IsDivisibleBy5And7");
            var number = 35;
            bool resultIsDivisibleBy5And7 = ConditionPracticeClass.IsDivisibleBy5And7(number);
            if (resultIsDivisibleBy5And7) Console.WriteLine($"{number} is divisible by 5 and 7!");
            else Console.WriteLine($"{number} is not divisible by 5 and 7!");

            SpaceAwait();

            // PerformOperation
            Console.WriteLine("PerformOperation");
            char[] chars = new char[]
            {
                '+',
                '-',
                'b'
            };

            double firstPerformOperation = 2.3d;
            double secondPerformOperation = 1.2d;

            foreach (char ch in chars)
            {
                var result = ConditionPracticeClass.PerformOperation(ch,
                    firstPerformOperation, secondPerformOperation);
                ShowPerformOperationResult(ch, firstPerformOperation,
                    secondPerformOperation, result);
            }

            SpaceAwait();

            // CheckNumber
            Console.WriteLine("CheckNumber");
            int[] numbers = new int[]
            {
                3,
                -7,
                0
            };

            foreach (int num in numbers)
            {
                string result = ConditionPracticeClass.CheckNumber(num);
                Console.WriteLine($"{num} is {result}");
            }

            SpaceAwait();

            // Is leap year
            Console.WriteLine("IsLeapYear");
            var leapYears = new int[] { 1996, 2016, 1875, 2001, 1539, 823 };
            foreach (int year in leapYears)
            {
                var result = ConditionPracticeClass.IsLeapYear(year);
                if (result) Console.WriteLine($"{year} is leap!");
                else Console.WriteLine($"{year} is not leap!");
            }

            SpaceAwait();

            // IsVowel
            Console.WriteLine("IsVowel");
            var letters = new char[] { 'a', 'B', 'c', 'd', 'E', 'V', 't', 'O' };
            foreach(char letter in letters)
            {
                bool result = ConditionPracticeClass.IsVowel(letter);
                if (result) Console.WriteLine($"{letter} is vowel!");
                else Console.WriteLine($"{letter} in not vowel!");
            }

            SpaceAwait();

            // IsPalindrome
            Console.WriteLine("IsPalindrome");
            var palindroms = new string[] { "vlv", "pertrep", "sdasd", "rolklop" };
            foreach(string palindrom in palindroms)
            {
                var result = ConditionPracticeClass.IsPalindrome(palindrom);
                if (result) Console.WriteLine($"{palindrom} is palindrom!");
                else Console.WriteLine($"{palindrom} is not palindrom!");
            }

            SpaceAwait();
        }

        private static void ShowPerformOperationResult(char oper, double first, 
            double second, double result)
            => Console.WriteLine($"{first} {oper} {second} = {result}");

        private static void SpaceAwait()
        {
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
