using System.Diagnostics;

namespace CalculatetheFormula
{
    internal class CalculatetheFormula
    {
        static double CalS1(int n)
        {
            double sum = 0;
            double cumulativeSum = 0;
            for (int i = 1; i <= n; i++)
            {
                cumulativeSum += i * i;
                sum += Math.Pow(-1, i + 1) / cumulativeSum;
            }
            return sum;
        }

        static double CalS2(int n)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-2, i) / Factorial(i);
            }

            return sum;
        }

        static double CalS5(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(-1, i + 1) / (2 * i);
            }

            return sum;
        }

        static double CalS6(int n)
        {
            double sum = 0;
            double cumulativeSum = 0;

            for (int i = 1; i <= n; i++)
            {
                cumulativeSum += i;
                sum += Math.Pow(-1, i + 1) / cumulativeSum;
            }

            return sum;
        }

        static double CalS7(int n)
        {
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(2, i) / Factorial(i);
            }

            return sum;
        }

        static double Factorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;

            double fact = 1;
            for (int i = 2; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }
        static void RunTests()
        {
            TestFunction("CalS1", CalS1, new[] { 1, 2, 3 }, new[] { 1.0, 0.8, 0.8714285714 });
            TestFunction("CalS2", CalS2, new[] { 1, 2, 3 }, new[] { -1.0, -3.0, -1.666666667 });
            TestFunction("CalS5", CalS5, new[] { 1, 2, 3 }, new[] { 0.5, 0.25, 0.166666667 });
            TestFunction("CalS6", CalS6, new[] { 1, 2, 3 }, new[] { 1.0, 0.833333333, 0.761904762 });
            TestFunction("CalS7", CalS7, new[] { 1, 2, 3 }, new[] { 3.0, 5.0, 6.333333333 });
        }

        static void TestFunction(string name, Func<int, double> func, int[] inputs, double[] expectedOutputs)
        {
            Console.WriteLine($"Function: {name}");
            for (int i = 0; i < inputs.Length; i++)
            {
                int input = inputs[i];
                double expected = expectedOutputs[i];

                Stopwatch stopwatch = Stopwatch.StartNew();
                double actual = func(input);
                stopwatch.Stop();

                //bool passed = actual == expected;

                bool passed = Math.Abs(actual - expected) < 1e-9;
                Console.WriteLine($"Input: {input}, Expected: {expected}, Actual: {actual}, Time: {stopwatch.ElapsedMilliseconds}ms, Result: {(passed ? "Passed" : "Failed")}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("S1: " + CalS1(n));
            Console.WriteLine("S2: " + CalS2(n));
            Console.WriteLine("S5: " + CalS5(n));
            Console.WriteLine("S6: " + CalS6(n));
            Console.WriteLine("S7: " + CalS7(n));

            RunTests();
        }
    }
}
