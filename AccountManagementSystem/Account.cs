using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal enum AccountType
    {
        Account,
        SavingAccount
    }

    internal class Account
    {
        public Account(string id, string accountNumber, string iBAN, string name, decimal balance, string? phone, string email, string password, int age, AccountType type)
        {
            Id = id;
            AccountNumber = accountNumber;
            IBAN = iBAN;
            Name = name;
            Balance = balance;
            Phone = phone;
            Email = email;
            Password = password;
            Age = age;
            type = type;
        }

        public string Id { get; set; } = null!;
        public string AccountNumber { get; set; } = null!;
        public string IBAN { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Balance { get; set; }
        public string? Phone { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Age { get; set; }
        public AccountType Type { get; set; }
    }
}
