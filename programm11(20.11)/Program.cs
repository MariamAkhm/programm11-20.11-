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
            Console.WriteLine("11.1");
            Console.WriteLine("Введите баланс сберегательного счета:");
            decimal balance = Convert.ToDecimal(Console.Read());
            long id = 0;
            BankAccount bankAccount = new BankAccount(balance, Type.Saving);
            Console.WriteLine("Введите сумму, которую вы хотите положить на счет");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            bankAccount.Deposit(sum);
            Fabric.CreateAccount(balance, Type.Saving);
            Fabric.CloseAccount(id);

            Console.WriteLine("11.2");
            Console.WriteLine("Введите высоту здания:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество этажей в здании");
            int countOfFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество квартир");
            int countOfApartments = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество подъездов");
            int countOfEntrances = Convert.ToInt32(Console.ReadLine());
            Building building = new Building(height, countOfFloors, countOfApartments, countOfEntrances);
            building.CountApartmentsOnFloor(countOfApartments, countOfFloors);
            Creator.CreateBuilding(height, countOfFloors, countOfApartments, countOfEntrances);
            Creator.CloseAccount(id);
            Console.ReadKey();
        }
    }
}
