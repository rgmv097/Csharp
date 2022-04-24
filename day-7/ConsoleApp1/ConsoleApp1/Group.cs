using System;

namespace ConsoleApp1
{
    internal class Group
    {
        public string No { get; set; }
        public byte Limit { get; set; }
        public string[] Students;
        public Group(string no, byte limit, string[] stundents)
        {
            No = no;
            Limit = limit;
            Students = stundents;
        }     
        int i = 0;
        public void AddStudent(Student student)
        {

            Students[i] = student.FullName();
            i++;
        }
        public void GetStudent()
        {
            int i = 1;  
            foreach (string student in Students)
            {
                
                Console.WriteLine(student);
            }  
        }
    }
}






