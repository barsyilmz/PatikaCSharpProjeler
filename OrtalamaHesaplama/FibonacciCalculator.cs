public class FibonacciCalculator
{
    public static List<int> CalculateFibonacciSeries(int depth)
    {
        List<int> fibonacciSeries = new List<int>();
        int prev = 0;
        int current = 1;

        for (int i = 0; i < depth; i++)
        {
            fibonacciSeries.Add(current);
            int next = prev + current;
            prev = current;
            current = next;
        }

        return fibonacciSeries;
    }
}
