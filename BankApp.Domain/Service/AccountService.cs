using BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Service
{
    public class AccountService
    {
        private List<Account> accounts;

        public AccountService()
        {
            accounts = new List<Account>();
        }

        public void RegisterAccount(Account account)
        {
            accounts.Add(account);
            Console.WriteLine("Hesap başarıyla kaydedildi.");
        }

        public void TransferMoney(string senderAccountNumber, string receiverAccountNumber, double amount)
        {
            Account sender = null;
            Account receiver = null;

            foreach (var account in accounts)
            {
                if (account.AccountNumber == senderAccountNumber)
                {
                    sender = account;
                }
                else if (account.AccountNumber == receiverAccountNumber)
                {
                    receiver = account;
                }
            }

            if (sender == null)
            {
                Console.WriteLine("Gönderen hesap bulunamadı.");
                return;
            }

            if (receiver == null)
            {
                Console.WriteLine("Alıcı hesap bulunamadı.");
                return;
            }

            if (sender.Balance < amount)
            {
                Console.WriteLine("Yetersiz bakiye.");
                return;
            }

            sender.Balance -= amount;
            receiver.Balance += amount;

            Console.WriteLine($"{amount} TL başarıyla {sender.Name} {sender.Surname}'nin hesabından {receiver.Name} {receiver.Surname}'nin hesabına transfer edildi.");
        }
    }
}

