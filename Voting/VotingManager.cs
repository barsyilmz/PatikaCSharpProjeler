public class VotingManager
{
    public static void StartVoting()
    {
        Console.WriteLine("Voting Uygulamasına Hoş Geldiniz!");

        Console.Write("Kullanıcı adınızı girin: ");
        string username = Console.ReadLine();

        User currentUser = DataManager.Users.FirstOrDefault(u => u.Username == username);

        if (currentUser == null)
        {
            Console.WriteLine("Sisteme kayıtlı değilsiniz. Kayıt oluşturmak için lütfen bir kullanıcı adı girin:");
            username = Console.ReadLine();
            currentUser = RegisterUser(username);
            DataManager.Users.Add(currentUser);
        }

        Console.WriteLine("Oylamak istediğiniz kategoriler:");
        for (int i = 0; i < DataManager.Categories.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {DataManager.Categories[i].Name}");
        }

        // Diğer kısım aynı...
    }

    public static User RegisterUser(string username)
    {
        return new User(username);
    }

    // Diğer metotlar aynı...
}
