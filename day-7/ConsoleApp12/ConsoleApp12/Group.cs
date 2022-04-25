using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    internal class Group
    {
        public string No;
        public byte Limit;
        private Student[] Students;


        public Group(string no,byte limit)
        {
            No= no;
            Limit = limit;
            Students = new Student[0];

        }
        public void AddStudent(Student student)
        {
            if (Students.Length < Limit)
            {
                Array.Resize(ref Students,Students.Length+1);
                Students[Students.Length-1] = student;
                Console.WriteLine($"{student.Name} adli telebe add olundu");
            }
            else { Console.WriteLine("Limit Dolub"); }
            
        }
        public void GetStudent()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name} {student.SurName}");
            }
        }
        
    }
}
