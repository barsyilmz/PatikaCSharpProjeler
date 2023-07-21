public class InputManager
{
    public static int GetDepthFromUser()
    {
        Console.Write("Fibonacci serisinin derinliğini girin: ");
        int depth;
        while (!int.TryParse(Console.ReadLine(), out depth) || depth < 1)
        {
            Console.Write("Geçersiz giriş! Pozitif bir tamsayı girin: ");
        }
        return depth;
    }
}
