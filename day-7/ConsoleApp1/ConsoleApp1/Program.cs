using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Group OF Limit: ");
            byte LimitOfGroup = Convert.ToByte(Console.ReadLine());
            Console.Write("Group of Number: ");
            string NumberOfGroup = Console.ReadLine();
            int count = 0;
            string name = default(string);
            string surname = default(string);
            string[] students = new string[LimitOfGroup];
            Group group = new Group(NumberOfGroup, LimitOfGroup, students);
            do 
            {    
                Console.Write("AD: ");
                name = Console.ReadLine();
                Console.Write("SOYAD: ");
                surname = Console.ReadLine();
                Student student = new Student(name, surname);
                students = new string[LimitOfGroup];
                group.AddStudent(student);
                count++;
            } while (count < LimitOfGroup);          
            group.GetStudent();


            


















        }
    }
}
