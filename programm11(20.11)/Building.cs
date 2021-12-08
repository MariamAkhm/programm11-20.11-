using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm11_20._11_
{
    class Building
    {
        
            private static long id = 1;
            private long number;
            private int height;
            private int countOfFloors;
            private int countOfApartments;
            private int countOfEntrances;
        public long ID()
        {
            return id++;
        }
        internal Building()
            {
                number = ID();
            }
            internal Building(int height)
            {
                number = ID();
                this.height = height;
            }
            internal Building(int height, int countOfFloors, int countOfApartments, int countOfEntrances)
            {
                number = ID();
                this.height = height;
                this.countOfFloors = countOfFloors;
                this.countOfApartments = countOfApartments;
                this.countOfEntrances = countOfEntrances;
            }
            public double HeightFloor(int height, int countOfFloors)
            {
                Console.WriteLine("Введите высоту здания");
                while (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите количество этажей в здании здания");
                while (!int.TryParse(Console.ReadLine(), out countOfFloors))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                double heightOfFloors;
                if (countOfFloors != 0)
                {
                    heightOfFloors = height / countOfFloors;
                }
                else
                {
                    heightOfFloors = height;
                }
                return heightOfFloors;
            }
            public int CountApartmentsInEntrance(int countOfApartments, int countOfEntrances)
            {
                Console.WriteLine("Введите количество квартир");
                while (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите количество квартир на этаже");
                while (!int.TryParse(Console.ReadLine(), out countOfFloors))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                int apartOfEntrances;
                if (countOfEntrances != 0)
                {
                    apartOfEntrances = countOfApartments / countOfEntrances;
                }
                else
                {
                    apartOfEntrances = countOfApartments;
                }
                return apartOfEntrances;
            }
            public int CountApartmentsOnFloor(int countOfApartments, int countOfFloors)
            {
                Console.WriteLine("Введите количество квартир");
                while (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите количество этажей в здании здания");
                while (!int.TryParse(Console.ReadLine(), out countOfFloors))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                int apartOfFloors;
                if (countOfFloors != 0)
                {
                    apartOfFloors = countOfApartments / countOfFloors;
                }
                else
                {
                    apartOfFloors = countOfApartments;
                }
                return apartOfFloors;
            }
    }
}
