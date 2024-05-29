using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string IdentiNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Trans
    {
        public string TransId { get; set; }
        public string GondericiHesapNum { get; set; }

        public string alıcıHesapNum { get; set; }

        public double Miktar { get; set; }
    }
}
