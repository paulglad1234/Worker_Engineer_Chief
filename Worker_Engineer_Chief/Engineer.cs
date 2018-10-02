using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker_Engineer_Chief
{
    abstract class Engineer : IWorker
    {
        public string[] FullName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        private BankAccount SalaryAccount { get; set; }//зарплатный счёт
                                                       //создается при принятии на работу (создании экземпляра класса)
                                                       //Баланс зарплатного счёта может изменять 
                                                       //(снимать\получать зп\покупать что-либо)
                                                       //только сам работник

        public Engineer(string surname, string name, string patronymic, int salary, string position)
        {
            string[] fullName = new string[3];
            fullName[0] = surname;
            fullName[1] = name;
            fullName[2] = patronymic;
            FullName = fullName;
            Salary = salary;
            SalaryAccount = new BankAccount();
            Position = position;
        }

        public abstract void Work();
        /*{
            //понятия не имею, что написать сюда. Инженеры много чего делают. 
            //Но пусть будет. Должен же работник работать
            //придумал, сделаю этот метод абстрактным
        }*/
        public void GetSalary()
        {
            SalaryAccount.InsertMoney(Salary);
        }
        public void BuyAGood(IGood good)//а почему бы не добавить ещё интерфейс?)
        {
            SalaryAccount.GetMoney(good.Price);
        }
        public void WithdrawMoney(int amount)//снять деньги
        {
            SalaryAccount.GetMoney(amount);
        }
        public void MoneyTransfer(int amount, int accountnumber)//перевод денег
        {
            SalaryAccount.MoneyTransfer(amount, accountnumber);
        }
        public void ChangeSalary(int newvalue)
        {
            Salary = newvalue;
        }
    }
}
