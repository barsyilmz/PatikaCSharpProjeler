# Voting Uygulaması

Pre-defined olarak belirlenen kategorilerde oy verebilme imkanı sunar. Kullanıcılar, sisteme kayıtlı olduğu takdirde kategorilere oy verebilirler. Sisteme kayıtlı olmayan kullanıcılar ise kayıt olup ardından oylamaya devam edebilirler.


## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `Category`: Kategori adını temsil eden sınıf.
   - `Name`: Kategorinin adını tutar.
   - `Category(string name)`: Yeni bir kategori oluşturur.

2. `User`: Kullanıcı adını temsil eden sınıf.
   - `Username`: Kullanıcının adını tutar.
   - `User(string username)`: Yeni bir kullanıcı oluşturur.

3. `DataManager`: Kategoriler ve kullanıcılar için veri yönetimi sağlayan sınıf.
   - `Categories`: Pre-defined olarak belirlenen kategorilerin listesi.
   - `Users`: Sisteme kayıtlı kullanıcıların listesi.
   - `DataManager` sınıfı örneklendirilmez, içerisinde sadece statik üyeler bulunur.

4. `VotingManager`: Oylama işlemlerini yöneten sınıf.
   - `StartVoting()`: Oylamayı başlatır ve kullanıcı adını alır. Kayıtlı değilse kayıt olmasına imkan verir ve oylamaya devam eder.
   - `RegisterUser(string username)`: Kullanıcıyı sisteme kaydeder.
   - `ShowVotingResults()`: Oylama sonuçlarını ekrana yazdırır.

5. `Program`: Uygulamayı başlatan sınıf.
   - `Main()`: Uygulamanın başlangıç noktasıdır.
