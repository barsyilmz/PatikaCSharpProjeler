# Sessiz Harf Kontrolü Uygulaması

Kullanıcıdan alınan bir string ifade içerisinde yanyana 2 tane sessiz harf (ünlü olmayan harf) varsa ekrana `true`, yoksa `false` yazdırır.


## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `InputManager`: Kullanıcıdan bir string ifade almak için gerekli metodu içerir.
    - `GetStringFromUser()`: Kullanıcıdan bir string ifade alır.

2. `StringManipulator`: Verilen string ifade içerisinde yanyana 2 tane sessiz harf olup olmadığını kontrol etmek için gerekli metodu içerir.
    - `HasConsecutiveConsonants(string input)`: Sessiz harf kontrolünü gerçekleştirir.

3. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.

## Notlar

- Kullanıcı tarafından girilen string ifade içerisinde en az 2 karakter olmalıdır.
