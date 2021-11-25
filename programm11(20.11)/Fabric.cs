using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace programm11_20._11_
{
    class Fabric
    {
        public static Hashtable hashtable=new Hashtable();
        static Fabric()
        {
            hashtable = new Hashtable();
        }


        public static void CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.ID();
            hashtable.Add(SHA256.Create(),bankAccount);
        }
        public static void CreateAccount(decimal balance)
        {
            BankAccount bankAccount = new BankAccount(balance);
            hashtable.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CreateAccount(Type accountType)
        {
            BankAccount bankAccount = new BankAccount(accountType);
            hashtable.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CreateAccount(decimal balance, Type accountType)
        {
            BankAccount bankAccount = new BankAccount(balance,accountType);
            hashtable.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CloseAccount(long id)
        {
            hashtable.Remove(id);
        }


    }
}
