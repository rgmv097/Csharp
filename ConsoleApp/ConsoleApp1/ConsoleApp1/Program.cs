using ConsoleApp1.Settings;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Heci Courses");
            int selection;
            do
            {
                Console.WriteLine("- - - - - - -");
                Console.WriteLine("1. Create Group");
                Console.WriteLine("2. Show ALl Groups");
                Console.WriteLine("3. Edit Group Names");
                Console.WriteLine("4. Add Student");
                Console.WriteLine("5. Show All Student");
                Console.WriteLine("6. Show Groups Of Students");
                Console.WriteLine("7. Delete Student");
                Console.WriteLine("8. Clear Console");
                Console.WriteLine("0. Exit");
                bool result = int.TryParse(Console.ReadLine(), out selection);
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        MenuSettings.CreateGroup();
                        break;
                    case 2:
                        MenuSettings.GetGroups();
                        break;
                    case 3:
                        MenuSettings.EditGroupNo();
                        break;
                    case 4:
                        MenuSettings.AddStudent();
                        break;
                    case 5:
                        MenuSettings.ShowAllStudents();
                        break;
                    case 6:
                        MenuSettings.GetGroupStudents();
                        break;
                    case 7:
                        MenuSettings.DeleteStudent();
                        break;
                    case 8:
                        Console.Clear();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Something went wrong");
                        break;
                }
            } while (selection != 0);
        }
    }
}
