public class InputManager
{
    public static int GetCircleRadiusFromUser()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius;
        while (!int.TryParse(Console.ReadLine(), out radius) || radius < 1)
        {
            Console.Write("Geçersiz giriş! Pozitif bir tamsayı girin: ");
        }
        return radius;
    }
}
