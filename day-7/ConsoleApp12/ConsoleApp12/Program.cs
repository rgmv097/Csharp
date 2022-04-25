using System;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qrupun Nomresi: ");
            string no = Console.ReadLine();
            Console.Write("Qrupun Limiti: ");
            byte limit = Convert.ToByte(Console.ReadLine());
            Group group = new Group(no, limit);

            do
            {

                Console.Write("AD: ");
                string name = Console.ReadLine();
                Console.Write("Soyad: ");
                string surname = Console.ReadLine();
                Student student = new Student(name, surname);
                group.AddStudent(student);
                limit--;
            } while (limit != 0);
            Console.WriteLine("- - - - - - -");
            group.GetStudent();
            
            
        }
    }
}
