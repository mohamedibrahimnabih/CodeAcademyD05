using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagementSystem
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string id, string accountNumber, string iBAN, string name, decimal balance, string? phone, string email, string password, int age, double intsRate, AccountType type) : base(id, accountNumber, iBAN, name, balance, phone, email, password, age, type)
        {
            IntsRate = intsRate;
        }

        public double IntsRate { get; set; }
    }
}
