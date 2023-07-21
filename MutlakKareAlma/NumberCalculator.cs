public class NumberCalculator
{
    public static void CalculateAndPrintResult(List<int> numbers)
    {
        int totalDifference = 0;
        int totalSquareDifference = 0;

        foreach (var number in numbers)
        {
            if (number < 67)
            {
                int difference = 67 - number;
                totalDifference += difference;
            }
            else
            {
                int difference = number - 67;
                totalSquareDifference += difference * difference;
            }
        }

        Console.WriteLine($"67'den küçük olanların farkları toplamı: {totalDifference}");
        Console.WriteLine($"67'den büyük olanların farklarının kareleri toplamı: {totalSquareDifference}");
    }
}
