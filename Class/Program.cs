using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            using (StreamReader readerStudent = new StreamReader("Students.txt"))
            {
                string tmp;
                while (!string.IsNullOrEmpty(tmp = readerStudent.ReadLine()))
                {
                    string name=tmp.Substring(0,tmp.IndexOf(' '));
                    tmp = tmp.Remove(0, tmp.IndexOf(' ')+1);
                    string surname=tmp.Substring(0,tmp.IndexOf(' '));
                    int group; 
                    if(!int.TryParse(tmp[tmp.Length-1].ToString(),out group))
                    {
                        group = 1;
                    }
                    students.Add(new Student(name, surname, group));
                }
            }
            


            using (StreamReader readerLottery = new StreamReader("Lottery.txt"))
            {
                string info;
                while (!string.IsNullOrEmpty(info = readerLottery.ReadLine()))
                {
                    var listStudentsInLottery = new List<Student>();
                    var winners = new List<string>();
                    Console.Write("Информация о конкурсе: ");
                    Console.WriteLine(info);
                    info=info.Replace(" ", "");
                    int countTickets;
                    if(!int.TryParse(info[info.Length-1].ToString(),out countTickets))
                    {
                        Console.WriteLine("Неверная запись билетов!");
                        countTickets = 0;
                    }
                    bool flag = true;
                    int tmp = 0;
                    while (flag && tmp<students.Count )
                    {
                        
                        Console.WriteLine("Выберете кто участвует?(По фамилии) или введите выход,чтобы закончить выбор студентов");
                        Student.PrintInfo(students);
                        string choose = Console.ReadLine();
                        if (choose.ToLower().Equals("выход"))
                        {
                            flag = false;
                            continue;
                        }
                        else if(Student.GetCheckStudent(choose, listStudentsInLottery))
                        {
                            Console.WriteLine("Данный студент уже участвует в конкурсе!");
                            continue;
                        }
                        Student.IsChooseStudent(choose, students, listStudentsInLottery);
                        Console.WriteLine("Студент был добавлен в список участников!");
                        tmp++;
                    }
                    Console.Clear();
                    Console.WriteLine("Все студенты выбраны!Начинается розыгрыш!");
                    
                    Random r = new Random();
                        while (countTickets > 0 && (listStudentsInLottery.Count>0))
                        {
                            for (int i = 0; i < listStudentsInLottery.Count; i++)
                            {
                                double defaultChanse = (double)100 / listStudentsInLottery.Count;
                                if (listStudentsInLottery[i].IsWon())
                                {
                                    if(r.Next(101) < defaultChanse / 2)
                                    {
                                        countTickets--;
                                        winners.Add(listStudentsInLottery[i].GetInfo());
                                        listStudentsInLottery.Remove(listStudentsInLottery[i]);
                                    }
                                
                                }                               
                                else if(r.Next(101) < defaultChanse)
                                {
                                    countTickets--;
                                    winners.Add(listStudentsInLottery[i].GetInfo());
                                    listStudentsInLottery.Remove(listStudentsInLottery[i]);                                   
                                }
                            }
                        }
                    File.AppendAllText("Result.txt", info+"\n");
                    File.AppendAllLines("Result.txt", winners);
                    

                    Console.Clear();
                    


                }
            }

        }

        
        
    }
}
