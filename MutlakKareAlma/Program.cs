class Program
{
    static void Main()
    {
        try
        {
            List<int> numbers = InputManager.GetNumbersFromUser();
            NumberCalculator.CalculateAndPrintResult(numbers);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
