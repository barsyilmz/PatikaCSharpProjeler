public class InputManager
{
    public static List<(int, int)> GetNumberPairsFromUser()
    {
        Console.Write("Kaç adet integer ikilisi gireceksiniz? ");
        int n = Convert.ToInt32(Console.ReadLine());

        List<(int, int)> numberPairs = new List<(int, int)>();

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"[{i}] İkiliyi girin (örn: 5, 8): ");
            string input = Console.ReadLine();
            string[] pairValues = input.Split(',');

            if (pairValues.Length != 2 || !int.TryParse(pairValues[0], out int firstNumber) || !int.TryParse(pairValues[1], out int secondNumber))
            {
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir integer ikilisi girin.");
                i--;
                continue;
            }

            numberPairs.Add((firstNumber, secondNumber));
        }

        return numberPairs;
    }
}
