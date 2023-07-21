public class OutputManager
{
    public static void PrintFibonacciSeries(List<int> fibonacciSeries)
    {
        Console.WriteLine("Fibonacci Serisi:");
        foreach (int number in fibonacciSeries)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    public static void PrintAverage(int average)
    {
        Console.WriteLine("Ortalama: " + average);
    }
}
