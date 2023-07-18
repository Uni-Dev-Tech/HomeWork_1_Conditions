using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // User greeting and option input
            Console.Title = "Welcome to console application";
            Console.WriteLine("Program was stated ...");
            Console.WriteLine("To continue, please input target option.");
            Console.WriteLine("Possible options:");
            Console.WriteLine("1 - Circle;");
            Console.WriteLine("2 - Quadrangle;");
            Console.WriteLine("3 - Triangle.");
            Console.WriteLine("Please, write down below chosen option name or number." +
                "Console application is waiting for your response.");;

            // Input determination and handling

            string userInput;
            bool isSucceed;
            int index = 0;

            do
            {
                userInput = Console.ReadLine().ToLower();

                switch (userInput)
                {
                    case "circle": index = 1; isSucceed = true; break;
                    case "quadrangle": index = 2; isSucceed = true; break;
                    case "triangle": index = 3; isSucceed = true; break;
                    default:

                        isSucceed = int.TryParse(userInput, out int result);
                        if (isSucceed)
                        {
                            if (result <= 0 || result > 3)
                            {
                                IncorrectInputMessage();
                                isSucceed = false;
                                continue;
                            }
                            else
                            {
                                isSucceed = true;
                                index = result;
                            }
                        }
                        else
                        {
                            IncorrectInputMessage();
                            isSucceed = false;
                            continue;
                        }

                        break;
                }

            } while (!isSucceed);

            switch (index)
            {
                case 1: CircleOption(); break;
                case 2: QuadrangleOption();  break;
                case 3: TriangleOption(); break;
            }

            Console.ReadLine();
        }

        private static void IncorrectInputMessage() 
            => Console.WriteLine("Input is incorrect! Please, read instructions again and repeat input!");

        private static void NegativeOrZeroInputMessage() => Console.WriteLine("Input can not be less or equal zero!");

        private static void TriangleOption()
        {
            Console.WriteLine("Please, write down the triangle sides below");

            var triangleSidesCount = 3;
            var inputs = new string[triangleSidesCount];
            for(int i = 0; i < triangleSidesCount; i++)
            {
                Console.WriteLine($"Side №{i + 1}");
                inputs[i] = Console.ReadLine();
            }

            var sides = new float[triangleSidesCount];
            bool isSuccess = false;
            for (int i = 0; i < inputs.Length; i++)
            {
                isSuccess = float.TryParse(inputs[i], out float result);
                if (!isSuccess) break;

                sides[i] = result;
            }

            if (!isSuccess)
            {
                IncorrectInputMessage();
                TriangleOption();
                return;
            }

            var isTriangleCorret = true;
            for (int i = 0; i < sides.Length; i++)
            {
                var temp = sides[i];
                var sum = 0f;
                
                for (int j = 0; j < sides.Length; j++)
                {
                    if (i == j) continue;

                    sum += sides[j];
                }

                if (sum <= temp)
                {
                    isTriangleCorret = false;
                    break;
                }
            }

            if (!isTriangleCorret)
            {
                Console.WriteLine("Input is incorrect! Triangle with inputted sides can not exist! Please, repeat input!");
                TriangleOption();
                return;
            }

            var P = 0f;
            var S = 0f;

            foreach (float side in sides)
            {
                P += side;
                S += side;
            }

            S /= 2;

            var temps = sides;
            for (int i = 0; i < temps.Length; i++) temps[i] = S - temps[i];

            var tempMultiplication = S;
            for (int i = 0; i < temps.Length; i++) tempMultiplication *= temps[i];

            S = MathF.Sqrt(tempMultiplication);

            Console.WriteLine($"The perimeter of a triangle is {P}");
            Console.WriteLine($"The area of a triangle is {S}");
        }

        private static void QuadrangleOption()
        {
            Console.WriteLine("Please, write down the quadrangle sides below");

            var quadrangleSidesCount = 2;
            var inputs = new string[quadrangleSidesCount];
            for (int i = 0; i < quadrangleSidesCount; i++)
            {
                Console.WriteLine($"Side №{i + 1}");
                inputs[i] = Console.ReadLine();
            }

            var sides = new float[quadrangleSidesCount];
            bool isSuccess = false;
            for (int i = 0; i < inputs.Length; i++)
            {
                isSuccess = float.TryParse(inputs[i], out float result);
                if (!isSuccess) break;

                sides[i] = result;
            }

            if (!isSuccess)
            {
                IncorrectInputMessage();
                QuadrangleOption();
                return;
            }

            for (int i = 0; i < sides.Length; i++)
            {
                var isPositive = sides[i] > 0 ? true : false;
                if (!isPositive)
                {
                    NegativeOrZeroInputMessage();
                    QuadrangleOption();
                    return;
                }
            }

            var P = 0f;
            var S = 1f;

            foreach (float side in sides)
            {
                P += side;
                S *= side;
            }

            P *= 2;

            Console.WriteLine($"The perimeter of a quadrangle is {P}");
            Console.WriteLine($"The area of a quadrangle is {S}");
        }

        private static void CircleOption()
        {
            Console.WriteLine("Please, write down the radius below");

            string input = Console.ReadLine();

            bool isSuccess = float.TryParse(input, out float radius);

            if (!isSuccess)
            {
                IncorrectInputMessage();
                CircleOption();
                return;
            }

            bool isItPositive = radius > 0 ? true : false;
            if (!isItPositive)
            {
                NegativeOrZeroInputMessage();
                CircleOption();
                return;
            }

            var p = 3.14f;

            var P = 2 * p * radius;
            var S = p * (radius * radius);

            Console.WriteLine($"The perimeter of a сircle is {P}");
            Console.WriteLine($"The area of a сircle is {S}");
        }
    }
}
