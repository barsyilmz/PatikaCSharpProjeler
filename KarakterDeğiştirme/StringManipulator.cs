public class StringManipulator
{
    public static string SwapFirstAndLastCharacter(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length <= 1)
        {
            return input;
        }

        char firstChar = input[0];
        char lastChar = input[input.Length - 1];

        // İlk ve son karakterin yerini değiştirerek yeni bir string oluşturun.
        string swappedString = lastChar + input.Substring(1, input.Length - 2) + firstChar;
        return swappedString;
    }
}
