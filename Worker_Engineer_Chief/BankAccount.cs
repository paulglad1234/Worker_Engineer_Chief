using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Engineer_Chief
{
    class BankAccount
    {
        private int number = 0;
        public Bank Bank { get; }
        public int Number { get; }
        public int Balance { get; private set; }
        public BankAccount()
        {
            number++;
            Number = number;
            Balance = 0;
            if (Bank == null)
                Bank = new Bank();
            Bank.accounts.Add(this);
        }

        public void InsertMoney(int amount)
        {
            Balance += amount;
        }
        public void GetMoney(int amount)
        {
            Balance -= amount;
        }
        public void MoneyTransfer(int amount, int accountnumber)
        {
            for (int i = 0; i < Bank.accounts.Count; i++)
            {
                if (Bank.accounts[i].Number == accountnumber)
                {
                    Bank.accounts[i].Balance += amount;
                    return;
                }
            }
        }
    }
}
