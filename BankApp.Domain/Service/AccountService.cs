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
        public void HesapAc (string Name ,double Balance)
        {
            
        }
    }
}
