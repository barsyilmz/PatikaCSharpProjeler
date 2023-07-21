# String Karakter Çıkartma Uygulaması

Kullanıcıdan alınan string ifade ve index çiftleri ile ilgili karakterleri çıkartarak sonuçları ekrana yazdıran uygulama.


## Sınıflar ve Metotlar

1. `StringManipulator`: String ifadeyi işlemek için gerekli metotları içerir.
    - `RemoveCharacterAtIndex(string input, int index)`: Verilen string ifadeden belirtilen indexteki karakteri çıkartır.

2. `InputManager`: Kullanıcıdan string ifade ve index bilgilerini almak için gerekli metotları içerir.
    - `GetStringAndIndexFromUser()`: Kullanıcıdan string ifade ve indexleri alır.

3. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.

## Notlar

- Kullanıcı, her bir string ve index çiftini virgülle ayırarak girmeli.
- Index, pozitif bir tamsayı olmalı.