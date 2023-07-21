# Barcode Generator/Reader Uygulaması

3rd party `ZXing` kütüphanesini kullanarak barcode üreten ve okuyan bir uygulamadır. Kullanıcının girdiği metni barcode'a dönüştürür ve belirli bir lokasyona kaydeder. Ardından, belirtilen lokasyondaki barcode'ı okur ve içeriğini ekrana yazdırır.

## Kullanılan Teknikler

- Console Application: Uygulama, C# Console Application olarak geliştirilmiştir.
- 3rd Party Library Import: Barcode üretmek ve okumak için `ZXing` kütüphanesi kullanılmıştır.
- Dosyaya Yazma: Oluşturulan barcode, kullanıcının belirttiği bir lokasyona kaydedilir.
- Dosyadan Okuma: Kaydedilen barcode, belirtilen lokasyondan okunarak içeriği ekrana yazdırılır.


## Barcode Oluşturma ve Okuma

Uygulama, aşağıdaki işlemleri gerçekleştirir:

- Kullanıcı, bir metin girerek barcode oluşturmayı başlatır.
- Oluşturulan barcode, PNG formatında belirtilen bir lokasyona kaydedilir.
- Kullanıcı, belirtilen lokasyondaki barcode'ı okumak için ENTER tuşuna basar.
- Uygulama, belirtilen lokasyondaki barcode'ı okur ve içeriğini ekrana yazdırır.

## Dikkat!

- Barcode üretmek ve okumak için `ZXing` kütüphanesini kullanıyoruz. Bu nedenle, uygulamayı çalıştırmadan önce `ZXing` kütüphanesini projenize eklemeyi unutmayın.
