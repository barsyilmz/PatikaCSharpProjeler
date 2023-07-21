class Program
{
    static void Main()
    {
        string input = InputManager.GetStringFromUser();
        string reversedString = StringReverse.ReverseString(input);
        Console.WriteLine("Ters Çevrilmiş String: " + reversedString);
    }
}
