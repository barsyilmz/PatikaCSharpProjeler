public class InputManager
{
    public static (string, int) GetStringAndIndexFromUser()
    {
        Console.Write("String ifadeyi ve indexi (örn: Algoritma,3): ");
        string input = Console.ReadLine();
        int commaIndex = input.IndexOf(',');
        if (commaIndex < 0 || commaIndex >= input.Length - 1)
        {
            throw new ArgumentException("Geçersiz giriş! String ifade ve index arasında virgülle ayırın.");
        }

        string str = input.Substring(0, commaIndex).Trim();
        int index;
        if (!int.TryParse(input.Substring(commaIndex + 1), out index) || index < 0)
        {
            throw new ArgumentException("Geçersiz giriş! Index pozitif bir tamsayı olmalıdır.");
        }

        return (str, index);
    }
}
