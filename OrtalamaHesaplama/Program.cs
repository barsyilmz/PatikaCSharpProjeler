using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int depth = InputManager.GetDepthFromUser();
        List<int> fibonacciSeries = FibonacciCalculator.CalculateFibonacciSeries(depth);
        OutputManager.PrintFibonacciSeries(fibonacciSeries);

        int average = CalculateAverage(fibonacciSeries);
        OutputManager.PrintAverage(average);
    }

    static int CalculateAverage(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Count;
    }
}
