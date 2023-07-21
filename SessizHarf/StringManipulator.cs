public class StringManipulator
{
    public static bool HasConsecutiveConsonants(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            return false;
        }

        string consonants = "bcdfghjklmnpqrstvwxyz";

        for (int i = 0; i < input.Length - 1; i++)
        {
            char currentChar = char.ToLower(input[i]);
            char nextChar = char.ToLower(input[i + 1]);

            if (consonants.Contains(currentChar) && consonants.Contains(nextChar))
            {
                return true;
            }
        }

        return false;
    }
}
