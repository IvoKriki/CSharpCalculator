using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Please choose an option ");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Times");
            Console.WriteLine("3 - Power");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Subtraction");
            Console.WriteLine("6 - Exit" + "\n");

            short result = short.Parse(Console.ReadLine());

            switch (result)
            {
                case 1: Sum(); break;
                case 2: Times(); break;
                case 3: Power(); break;
                case 4: Division(); break;
                case 5: Subtraction(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.WriteLine("Input the first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            var sumResult = firstValue + secondValue;
            Console.WriteLine($"The result is: {sumResult}");

            Console.ReadKey();
            Menu();
        }
        static void Times()
        {
            Console.WriteLine("Input the first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            var timesResult = firstValue * secondValue;
            Console.WriteLine("The result is: " + timesResult);

            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.WriteLine("Input the first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            //var divisionResult = firstValue / secondValue;
            Console.WriteLine("The result is: " + (firstValue / secondValue));

            Console.ReadKey();
            Menu();
        }
        static void Subtraction()
        {
            Console.WriteLine("Input the first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            //var subtractionResult = firstValue - secondValue;
            Console.WriteLine($"The result is: {firstValue - secondValue}");

            Console.ReadKey();
            Menu();
        }
        static void Power()
        {
            Console.WriteLine("Input the first value");
            var firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second value");
            var secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine($"The result is: { Math.Pow(firstValue, secondValue)}");

            Console.ReadKey();
            Menu();
        }
    }
}
