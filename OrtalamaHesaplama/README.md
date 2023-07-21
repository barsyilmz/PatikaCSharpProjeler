# Fibonacci Serisi Ortalama Hesaplama Uygulaması

Kullanıcının girdiği bir derinlik değerine göre fibonacci serisini hesaplar ve bu serideki sayıların ortalamasını ekrana yazdırır. Ayrıca, "Single Responsibility" kuralına uygun şekilde, kod parçaları sınıflara ve metotlara ayrılmıştır.

## Sınıflar ve Metotlar

Uygulama, aşağıdaki sınıflar ve metotlarla yapılandırılmıştır:

1. `FibonacciCalculator`: Fibonacci serisini hesaplamak için gerekli metotları içerir.
    - `CalculateFibonacciSeries(int depth)`: Verilen derinlik değerine göre Fibonacci serisini hesaplar.

2. `InputManager`: Kullanıcıdan derinlik değerini almak için gerekli metotları içerir.
    - `GetDepthFromUser()`: Kullanıcıdan fibonacci serisinin derinliğini alır.

3. `OutputManager`: Sonuçları ekrana yazdırmak için gerekli metotları içerir.
    - `PrintFibonacciSeries(List<int> fibonacciSeries)`: Hesaplanan Fibonacci serisini ekrana yazdırır.
    - `PrintAverage(int average)`: Serideki sayıların ortalamasını ekrana yazdırır.

4. `Program`: Uygulamayı çalıştırmak için gerekli metotları içerir ve diğer sınıfları kullanır.
    - `Main()`: Uygulamanın başlangıç noktasıdır.
