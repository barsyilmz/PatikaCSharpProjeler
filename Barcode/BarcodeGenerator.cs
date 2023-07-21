using System;
using System.Drawing;
using ZXing;
using ZXing.Common;

public class BarcodeGenerator
{
    public static void GenerateBarcode(string text, string savePath)
    {
        var writer = new BarcodeWriter
        {
            Format = BarcodeFormat.CODE_128,
            Options = new EncodingOptions
            {
                Width = 300,
                Height = 100
            }
        };

        var barcodeBitmap = writer.Write(text);

        barcodeBitmap.Save(savePath, System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("Barcode oluşturuldu ve kaydedildi.");
    }
}
