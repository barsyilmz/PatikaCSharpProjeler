# İlk ve Son Karakter Değiştirme Uygulaması

Kullanıcıdan alınan bir string ifade içerisindeki ilk ve son karakterin yerini değiştirerek sonucu ekrana yazdırır.

## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `InputManager`: Kullanıcıdan bir string ifade almak için gerekli metodu içerir.
    - `GetStringFromUser()`: Kullanıcıdan bir string ifade alır.

2. `StringManipulator`: Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirmek için gerekli metodu içerir.
    - `SwapFirstAndLastCharacter(string input)`: İlk ve son karakteri yer değiştirerek yeni bir string oluşturur.

3. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.

## Notlar

- Kullanıcı tarafından girilen string ifade içerisinde en az 2 karakter olmalı.