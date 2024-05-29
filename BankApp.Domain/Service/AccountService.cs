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
        private List<Account> accounts = new(); 

        public AccountService() 
        {
            accounts = new List<Account>();
        }

        public int AccountNumber { get; private set; }

        public void HesapAc (string name ,double startBalance, string accountsNumber)
        {

            var yeniHesap = new Account
            {
                AccountNumber = accountsNumber,
               Name = name,
                Balance = startBalance
            };
            accounts.Add(yeniHesap);
        }
        public void ParaTransEt ( int gondericiHesapNum,int alıcıHesapNum,double miktar)
        {
            var göndericiHesap = accounts.FirstOrDefault(h => AccountNumber == gondericiHesapNum);
            var alıcıHesap = accounts.FirstOrDefault(h => AccountNumber == alıcıHesapNum);

            if (göndericiHesap != null && alıcıHesap != null)
            {
                if(göndericiHesap.Balance >= miktar)
                {
                    göndericiHesap.Balance -= miktar;
                    alıcıHesap.Balance += miktar;
                    Console.WriteLine($"{miktar} TL, {göndericiHesap.Name}nin hesabından {alıcıHesap.Name} nib hesabına transfer edildi.");
                }
                else
                {
                    Console.WriteLine("hesapta yeterli bakiye yok");
                }
            }
            else
            {
                Console.WriteLine("hesap numarası geçersiz");
            }

            
            {


            }
        }

    }
}
