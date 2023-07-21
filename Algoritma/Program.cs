class Program
{
    static void Main()
    {
        try
        {
            (string str, int index) = InputManager.GetStringAndIndexFromUser();
            string result = StringManipulator.RemoveCharacterAtIndex(str, index);
            Console.WriteLine("Output: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
