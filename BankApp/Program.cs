using BankApp.Domain.Entities;
using BankApp.Domain.Service;

class Program
{
    static void Main(string[] args)
    {
        AccountService bank = new AccountService();

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

        bank.TransferMoney("123456789", "987654321", 1000);
    }
}
}