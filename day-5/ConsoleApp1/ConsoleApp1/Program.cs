using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Chingiz", "Rahimov", "P324", 81,false);
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.PointsIncrease());
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool Graduated;
        public Student(string name, string surname, string group, byte point, bool isGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            Graduated = isGraduated;
        }
        public string GetFullName()
        {

            return $"Name: {Name}  FullName: {Surname}";
        }
        public string GetInfo()
        {
            if (Graduated==true)
            {
                return $"Name: {Name}  FullName: {Surname} Group: {Group} Point: {Point} \nMezun olub";              
            }
            else
            {
                return $"Name: {Name}  FullName: {Surname} Group: {Group} Point: {Point} \nMezun olmayib";              
            }

        }
        public string PointsIncrease()
        {
            if (Point > 80) { return "Ikinci Imthana gire biler"; }
            else { return "Ikinci Imtahana gire bilmez"; }
        }
    }
}
