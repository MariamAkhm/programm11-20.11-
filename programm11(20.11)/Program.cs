using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm11_20._11_
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = Convert.ToDecimal(Console.Read());
            Fabric.CreateAccount(balance, Type.Saving);       
        }
    }
}
