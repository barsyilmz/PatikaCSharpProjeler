# Sayı Farkları Hesaplama Uygulaması

Kullanıcıdan alınan n tane sayının 67'den küçük veya büyük olup olmadığını kontrol ederek, 67'den küçük olanların farklarını toplayıp 67'den büyük olanların farklarının karelerini alarak toplamını ekrana yazdırır.


## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `InputManager`: Kullanıcıdan n tane sayıyı almak için gerekli metotları içerir.
    - `GetNumbersFromUser()`: Kullanıcıdan sayıları alır.

2. `NumberCalculator`: Kullanıcıdan alınan sayıların işlemlerini gerçekleştiren metotları içerir.
    - `CalculateAndPrintResult(List<int> numbers)`: Sayı farklarını hesaplar ve sonucu ekrana yazdırır.

3. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.