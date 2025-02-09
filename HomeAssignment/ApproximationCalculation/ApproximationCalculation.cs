using System.Diagnostics;

namespace ApproximationCalculation
{
    internal class ApproximationCalculation
    {
        static double CalPi(double epsilon)
        {
            double pi = 0;
            double generalTerm = 0;
            int n = 0;
            do
            {
                generalTerm = Math.Pow(-1, n) / (2 * n + 1);
                pi += generalTerm;
                n++;
            } while (Math.Abs(generalTerm) >= epsilon);
            return pi * 4;
        }

        static double CalSin(double x, double epsilon)
        {
            double sin = 0;
            double generalTerm = x;
            int n = 1;
            while (Math.Abs(generalTerm) >= epsilon)
            {
                generalTerm = Math.Pow(-1, n - 1) * Math.Pow(x, 2 * n - 1) / Factorial(2 * n - 1);
                sin += generalTerm;
                n++;
            }
            return sin;
        }

        static double CalLn(double x, double epsilon)
        {
            double ln = 0;
            int n = 1;
            while (x >= 2)
            {
                ln += Math.Log(2);
                x /= 2;
            }

            x -= 1;
            double generalTerm = x;

            while (Math.Abs(generalTerm) >= epsilon)
            {
                generalTerm = Math.Pow(-1, n - 1) * Math.Pow(x, n) / n;
                ln += generalTerm;
                n++;
            }
            return ln;
        }

        static double CalCos(double x, double epsilon)
        {
            double cos = 0;
            double generalTerm = 1;
            int n = 0;
            while (Math.Abs(generalTerm) >= epsilon)
            {
                generalTerm = Math.Pow(-1, n) * Math.Pow(x, 2 * n) / Factorial(2 * n);
                cos += generalTerm;
                n++;
            }
            return cos;
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

        static void RunTests(double epsilon)
        {
            TestFunction(
                "CalSin",
                x => CalSin(x, epsilon),
                new double[] { 0, 1.4, 2.3 },
                new[] { Math.Sin(0), Math.Sin(1.4), Math.Sin(2.3) }
            );
            TestFunction(
                "CalLn",
                x => CalLn(x, epsilon),
                new double[] { 1, 2, 3 },
                new double[] { Math.Log(1), Math.Log(2), Math.Log(3) }
            );
            TestFunction(
                "CalCos",
                x => CalCos(x, epsilon),
                new double[] { 0, 1.2, 1.5 },
                new[] { Math.Cos(0), Math.Cos(1.2), Math.Cos(1.5) }
            );
        }

        static void TestFunction(
            string name,
            Func<double, double> func,
            double[] inputs,
            double[] expectedOutputs
        )
        {
            Console.WriteLine();
            Console.WriteLine($"Function: {name}");
            for (int i = 0; i < inputs.Length; i++)
            {
                double input = inputs[i];
                double expected = expectedOutputs[i];

                Stopwatch stopwatch = Stopwatch.StartNew();
                double actual = func(input);
                stopwatch.Stop();

                //bool passed = actual == expected;

                bool passed = Math.Abs(actual - expected) < 1e-10;
                Console.WriteLine(
                    $"Input: {input}, Expected: {expected}, Actual: {actual}, Time: {stopwatch.ElapsedMilliseconds}ms, Result: {(passed ? "Passed" : "Failed")}"
                );
            }
        }

        static void Main(string[] args)
        {
            double epsilon = 0.00000001;
            double piResult = CalPi(epsilon);
            Console.WriteLine($"Pi = {piResult}");
            RunTests(epsilon);
        }
    }
}
