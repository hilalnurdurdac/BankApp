using BankApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var göndericiHesap = 
        }
    }
}
