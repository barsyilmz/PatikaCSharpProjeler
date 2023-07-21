public class InputManager
{
    public static int GetTriangleSizeFromUser()
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size < 1)
        {
            Console.Write("Geçersiz giriş! Pozitif bir tamsayı girin: ");
        }
        return size;
    }
}
