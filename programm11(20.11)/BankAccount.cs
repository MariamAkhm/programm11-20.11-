using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm11_20._11_
{
    public enum Type{Current,Saving};
    class BankAccount
    {
        private Type accountType;
        private decimal balance;
        private static long id=0;
        private long number; 
        public long ID()
        {
            return id++;
        }
        internal BankAccount()
        {
            number = ID();
        }
        internal BankAccount(decimal balance)
        {
            number = ID();
            this.balance = balance;
        }
        internal BankAccount(Type accountType)
        {
            number = ID();
            this.accountType = accountType;
        }
        internal BankAccount(decimal balance, Type accountType)
        {
            this.accountType = accountType;
            this.balance = balance;
        }

        public void WithDraw(decimal sum)
        {
            Console.WriteLine("Введите сумму");
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            if (sum<=balance)
            {
                balance -= sum;
            }
            else
            {
                Console.WriteLine("ошибка, недостаточно средств!");
            }
        }
        public void Deposit(decimal sum)
        {
            Console.WriteLine("Введите сумму");
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            balance += sum;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Номер банковского счета:"+number);
            Console.WriteLine("Account balance"+balance);
            Console.WriteLine("Тип банковского счета:"+accountType);
        }
    }
}

