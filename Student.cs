using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DZ9
{
    class Student : IStudent
    {
        Random rand = new Random();
        public int[] Mark = new int[5];
        public DayOfWeek Day { get; set; }
        public void CalcAvgMark()
        {
            Console.WriteLine(Mark.Average());
        }
        public void CheckMyMarks()
        {
            for (int i = 0; i < Mark.Length; i++)
            {
                Mark[i] = rand.Next(2, 5);
            }
            for (int i = 0; i < Mark.Length; i++)
            {
                Console.Write(Mark[i] + " ");
            }
        }
        public void SchoolScheduleForToday()
        {
            if(Day == 0)
            {
                Console.WriteLine("1.Математика" + "\n2.Физика" + "\n3.Биология" + "\n4.Химия");
            }
        }
    }
}
