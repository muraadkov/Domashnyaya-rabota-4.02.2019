using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Day = 0;
            Console.Write("Ваши оценки: ");
            student.CheckMyMarks();
            Console.Write("\nВаша средняя оценка: ");
            student.CalcAvgMark();
            Console.WriteLine("Ваше расписание на сегодня: ");
            student.SchoolScheduleForToday();
            Console.Read();
        }
    }
}
