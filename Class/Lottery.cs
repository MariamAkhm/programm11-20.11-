using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Class
{
    class Lottery
    {
        internal static void PrintInfo()
        {
            using (StreamReader readerLottery = new StreamReader("Lottery.txt"))
            {
                Console.Write("Информация о конкурсе: ");
                Console.WriteLine(readerLottery.ReadLine());
                
            }
        }
        
    }
}
