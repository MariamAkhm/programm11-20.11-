using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace programm11_20._11_
{
    class Creator
    {
        public static Hashtable hashtable = new Hashtable();
        static Creator()
        {
            hashtable = new Hashtable();
        }
        public static void CreateBuilding()
        {
            Building building = new Building();
            building.ID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CreateBuilding(int height)
        {
            Building building = new Building();
            building.ID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CreateBuilding(int height, int countOfFloors, int countOfApartments, int countOfEntrances)
        {
            Building building = new Building();
            building.ID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CloseAccount(long id)
        {
            hashtable.Remove(id);
        }
    }
}
