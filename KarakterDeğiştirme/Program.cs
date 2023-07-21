class Program
{
    static void Main()
    {
        try
        {
            string inputString = InputManager.GetStringFromUser();
            string swappedString = StringManipulator.SwapFirstAndLastCharacter(inputString);

            Console.WriteLine("Değiştirilmiş String: " + swappedString);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
