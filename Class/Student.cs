using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Student
    {
        private string name;
        private string surname;
        private int group;

        public Student(string name,string surnamme,int group)
        {
            this.name = name;
            this.surname = surnamme;
            this.group = group;
        }

        internal static void PrintInfo(List<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.name} {student.surname} {student.group}");
            }
        }

        internal static void IsChooseStudent(string choose, List<Student> students,List<Student> choosenStudents)
        {
            bool isFounded = false;
            foreach (var student in students)
            {
                if (student.surname.Equals(choose))
                {
                    choosenStudents.Add(student);
                    isFounded = true;                    
                }
            }
            if (!isFounded)
            {
                Console.WriteLine("Студент с данной фамилией не найден!");
            }
        }

        internal static bool GetCheckStudent(string choose, List<Student> listStudentsInLottery)
        {
            foreach (var student in listStudentsInLottery)
            {
                if (student.surname.Equals(choose))
                {
                    return true;
                }
            }
            return false;
        }

        internal string GetInfo()
        {
            return $"{name} {surname} {group}";
        }

        internal bool IsWon()
        {
            using (StreamReader readerWinners=new StreamReader("Result.txt"))
            {
                string tmp;
                while ((tmp = readerWinners.ReadLine()) != null)
                {
                    if (tmp.Equals(GetInfo()))
                    {
                        return true;
                    }
                }               
                return false;
            }
        }
    }
}
