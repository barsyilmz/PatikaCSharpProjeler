public class StringManipulator
{
    public static string RemoveCharacterAtIndex(string input, int index)
    {
        if (index < 0 || index >= input.Length)
        {
            return input;
        }

        return input.Remove(index, 1);
    }
}
