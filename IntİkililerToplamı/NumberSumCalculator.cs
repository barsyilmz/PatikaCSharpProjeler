public class NumberSumCalculator
{
    public static void CalculateSum(List<(int, int)> numberPairs)
    {
        foreach (var (firstNumber, secondNumber) in numberPairs)
        {
            int sum = firstNumber + secondNumber;
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"Toplamın karesi: {sum * sum}");
            }
            else
            {
                Console.WriteLine($"Toplam: {sum}");
            }
        }
    }
}
