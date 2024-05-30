using BankApp.Domain.Entities;
using BankApp.Domain.Service;

class Program
{
    static void Main(string[] args)
    {
        AccountService bank = new AccountService();
        Console.WriteLine("1. Kaydol");
        Console.WriteLine("2. Giriş");
        Console.WriteLine("3.Hesap Sorgulama");
        Console.WriteLine("4.Para çekme");
        Console.WriteLine("5.Para Transfer");
        Console.WriteLine("6.Çıkış");
        Console.Write("Bir seçenek seçin: ");
        string option = Console.ReadLine();


        Account account1 = new Account
        {
            Id = Guid.NewGuid(),
            Name = "Ali",
            Surname = "Yılmaz",
            Email = "ali@example.com",
            Address = "Istanbul",
            IdentiNumber = "12345678901",
            AccountNumber = "123456789",
            Password = "password1",
            Balance = 5000,
            PhoneNumber = "1234567890"
        };

        Account account2 = new Account
        {
            Id = Guid.NewGuid(),
            Name = "Ayşe",
            Surname = "Kaya",
            Email = "ayse@example.com",
            Address = "Ankara",
            IdentiNumber = "09876543210",
            AccountNumber = "987654321",
            Password = "password2",
            Balance = 3000,
            PhoneNumber = "0987654321"
        };

        bank.RegisterAccount(account1);
        bank.RegisterAccount(account2);

        Console.WriteLine("Transfer edilecek miktarı giriniz:");
        double transferAmount;
        while (!double.TryParse(Console.ReadLine(), out transferAmount) || transferAmount <= 0)
        {
            Console.WriteLine("Geçersiz miktar. Lütfen pozitif bir sayı girin:");
        }




        bank.TransferMoney("123456789", "987654321", transferAmount);
    }
}
