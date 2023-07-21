class Program
{
    static void Main()
    {
        try
        {
            string inputString = InputManager.GetStringFromUser();
            bool hasConsecutiveConsonants = StringManipulator.HasConsecutiveConsonants(inputString);

            Console.WriteLine("Sonuç: " + hasConsecutiveConsonants);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
