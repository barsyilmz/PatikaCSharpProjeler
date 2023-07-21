class Program
{
    static void Main()
    {
        Console.WriteLine("Barcode oluşturmak için bir metin girin:");
        string text = Console.ReadLine();

        string savePath = "barcode.png";

        BarcodeGenerator.GenerateBarcode(text, savePath);

        Console.WriteLine("\nBarcode oluşturuldu. Devam etmek için bir tuşa basın...");
        Console.ReadKey();

        Console.Clear();

        Console.WriteLine($"Kaydedilen barcode'ın dosya yolu: {savePath}");
        Console.WriteLine("\nBarcode'ı okumak için ENTER tuşuna basın...");
        Console.ReadLine();

        BarcodeReader.ReadBarcode(savePath);

        Console.WriteLine("\nBarcode okuma tamamlandı.");
    }
}
