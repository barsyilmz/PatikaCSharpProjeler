using System;
using ZXing;

public class BarcodeReader
{
    public static void ReadBarcode(string filePath)
    {
        var barcodeReader = new BarcodeReader();

        var barcodeBitmap = (Bitmap)Image.FromFile(filePath);

        var result = barcodeReader.Decode(barcodeBitmap);

        if (result != null)
        {
            Console.WriteLine($"Okunan Metin: {result.Text}");
        }
        else
        {
            Console.WriteLine("Barcode okunamadı.");
        }
    }
}
