class Program
{
    static void Main()
    {
        try
        {
            Shape selectedShape = InputManager.GetShapeFromUser();
            InputManager.GetDimensionsFromUser(selectedShape);
            string calculation = InputManager.GetCalculationFromUser();

            double result;
            if (calculation == "alan")
            {
                result = selectedShape.CalculateArea();
            }
            else if (calculation == "çevre")
            {
                result = selectedShape.CalculatePerimeter();
            }
            else
            {
                throw new ArgumentException("Geçersiz hesaplama tipi!");
            }

            Console.WriteLine($"Seçilen Şekil: {selectedShape.Name}");
            Console.WriteLine($"Hesaplanan {calculation}: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hata: " + ex.Message);
        }
    }
}
