# Geometrik Şekil Alan Hesaplama Uygulaması

Kullanıcıdan alınan geometrik şekil ve kenar bilgilerine göre, belirtilen boyutta alan veya çevre hesaplamalarını gerçekleştirir. Kullanıcı, Daire, Üçgen, Kare, Dikdörtgen vb. gibi farklı geometrik şekiller arasından seçim yaparak hesaplamaları gerçekleştirebilir.

## Sınıflar ve Metotlar

1. `Shape`: Abstract bir sınıf olup, farklı geometrik şekiller için temel özellikleri ve hesaplamaları içerir.
    - `Name`: Şekil adını döndüren abstract bir özellik.
    - `CalculateArea()`: Şeklin alanını hesaplayan abstract bir metot.
    - `CalculatePerimeter()`: Şeklin çevresini hesaplayan abstract bir metot.

2. `Circle`, `Triangle`, `Square`, `Rectangle`: Geometrik şekilleri temsil eden sınıflar olup, `Shape` sınıfını miras alır ve hesaplamalarını gerçekleştirir.

3. `InputManager`: Kullanıcıdan şekil, kenar bilgileri ve hesaplanmak istenen boyutu almak için gerekli metotları içerir.
    - `GetShapeFromUser()`: Kullanıcıdan geometrik şekil seçimini alır.
    - `GetDimensionsFromUser(Shape shape)`: Kullanıcıdan şekle göre kenar bilgilerini alır.
    - `GetCalculationFromUser()`: Kullanıcıdan hesaplanmak istenen boyutu alır.

4. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.