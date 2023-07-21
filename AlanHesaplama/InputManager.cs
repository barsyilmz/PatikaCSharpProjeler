public class InputManager
{
    public static Shape GetShapeFromUser()
    {
        Console.WriteLine("Geometrik şekil seçin: (Daire, Üçgen, Kare, Dikdörtgen)");
        string shapeName = Console.ReadLine().ToLower();

        switch (shapeName)
        {
            case "daire":
                return new Circle();
            case "üçgen":
                return new Triangle();
            case "kare":
                return new Square();
            case "dikdörtgen":
                return new Rectangle();
            default:
                throw new ArgumentException("Geçersiz şekil adı!");
        }
    }

    public static void GetDimensionsFromUser(Shape shape)
    {
        if (shape is Circle circle)
        {
            Console.Write("Dairenin yarıçapını girin: ");
            circle.Radius = Convert.ToDouble(Console.ReadLine());
        }
        else if (shape is Triangle triangle)
        {
            Console.Write("Üçgenin kenar uzunluğunu girin (Kenar A): ");
            triangle.SideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin kenar uzunluğunu girin (Kenar B): ");
            triangle.SideB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üçgenin kenar uzunluğunu girin (Kenar C): ");
            triangle.SideC = Convert.ToDouble(Console.ReadLine());
        }
        else if (shape is Square square)
        {
            Console.Write("Karenin kenar uzunluğunu girin: ");
            square.Side = Convert.ToDouble(Console.ReadLine());
        }
        else if (shape is Rectangle rectangle)
        {
            Console.Write("Dikdörtgenin genişliğini girin: ");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin yüksekliğini girin: ");
            rectangle.Height = Convert.ToDouble(Console.ReadLine());
        }
    }

    public static string GetCalculationFromUser()
    {
        Console.WriteLine("Hesaplamak istediğiniz boyutu seçin: (Alan, Çevre)");
        return Console.ReadLine().ToLower();
    }
}
