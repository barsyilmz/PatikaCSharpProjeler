class Program
{
    static void Main()
    {
        try
        {
            List<(int, int)> numberPairs = InputManager.GetNumberPairsFromUser();
            NumberSumCalculator.CalculateSum(numberPairs);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
