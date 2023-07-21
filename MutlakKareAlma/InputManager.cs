public class InputManager
{
    public static List<int> GetNumbersFromUser()
    {
        Console.Write("Kaç adet sayı gireceksiniz? ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<int> numbers = new List<int>();

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"[{i}] Sayıyı girin: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir sayı girin.");
                i--;
            }
        }

        return numbers;
    }
}
