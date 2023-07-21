# ATM Uygulaması

ATM üzerinden yapılabilecek temel işlemleri gerçekleştirmenizi sağlar. Para çekme, para yatırma ve ödeme yapma gibi işlemlerle kullanıcıların hesaplarını yönetmelerine imkan tanır. Ayrıca gün sonu alındığında yapılan işlemlerin logları ve potansiyel hatalı girişlerin logları belirli bir dosyaya kaydedilir.


## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `User`: Kullanıcı adı ve şifresini temsil eden sınıf.
   - `Username`: Kullanıcının adını tutar.
   - `Password`: Kullanıcının şifresini tutar.
   - `User(string username, string password)`: Yeni bir kullanıcı oluşturur.

2. `Transaction`: İşlem bilgilerini temsil eden sınıf.
   - `TransactionType`: İşlemin türünü (örn. para çekme, para yatırma) tutar.
   - `Amount`: İşlem miktarını tutar.
   - `TransactionDate`: İşlemin tarihini tutar.
   - `Transaction(string transactionType, double amount)`: Yeni bir işlem oluşturur.

3. `DataManager`: Kullanıcılar ve işlemler için veri yönetimi sağlayan sınıf.
   - `Users`: Önceden tanımlanmış kullanıcıların listesi.
   - `Transactions`: Yapılan işlemlerin listesi.
   - `DataManager` sınıfı örneklendirilmez, içerisinde sadece statik üyeler bulunur.

4. `ATM`: ATM işlemlerini yöneten sınıf.
   - `StartATM()`: ATM uygulamasını başlatır ve kullanıcı adı ve şifre istenir.
   - `ShowMenu()`: ATM işlem menüsünü gösterir.
   - `WithdrawMoney(User user)`: Para çekme işlemini gerçekleştirir.
   - `DepositMoney(User user)`: Para yatırma işlemini gerçekleştirir.
   - `MakePayment(User user)`: Ödeme yapma işlemini gerçekleştirir.
   - `EndOfDay()`: Gün sonu alındığında işlem loglarını ve hatalı giriş loglarını dosyaya kaydeder.

5. `Program`: Uygulamayı başlatan sınıf.
   - `Main()`: Uygulamanın başlangıç noktasıdır.
