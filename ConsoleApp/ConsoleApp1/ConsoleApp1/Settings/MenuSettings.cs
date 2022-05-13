using ConsoleApp1.Enum;
using ConsoleApp1.Models;
using System;

namespace ConsoleApp1.Settings
{
    internal static class MenuSettings
    {
        public static GroupSettings groupSettings = new GroupSettings();
        public static void CreateGroup()
        {
            Console.WriteLine("Group is Online or Offline? On/Off");
            bool isOnline=false;
            string Choose;
            do
            {
                Choose = (Console.ReadLine());
                Choose =Choose.ToLower().Trim();
                if (Choose == "on")
                {
                    isOnline = true;
                    break;
                }
                else if (Choose == "off")
                {
                    isOnline = false;
                    break;
                }
                else
                {
                    Console.WriteLine("- - - - - -\nPls select correct variant");

                }
            } while (Choose != "on" && Choose != "off");
            foreach (var item in System.Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }
            object category;
            bool categoryResult = System.Enum.TryParse(typeof(Categories), Console.ReadLine(), out category);
            if (categoryResult)
            {

                groupSettings.CreateGroup((Categories) category, isOnline);
            }
            else
            {
                Console.WriteLine("Pls select correct variant");
            }

        }
        public static void GetGroups()
        {
            groupSettings.GetAllGroupList();
        }
        public static void EditGroupNo()
        {
            Console.WriteLine("Please enter Group no");
            string OldNo = Console.ReadLine();

            Console.WriteLine("Please enter new Grup no");
            string NewNo = Console.ReadLine();

            groupSettings.EditGroupNo(OldNo, NewNo);
        }
        public static void AddStudent()
        {           
            Console.Write("Enter Full Name: ");
            string fullName=Console.ReadLine();
            Console.Write("Enter Group Name: ");
            string GroupNo=Console.ReadLine();
            Console.Write("Enter insured or uninsured ");
            string Select;
            bool isType = false;
            do
            {
                Console.WriteLine("Choose: I or U");
                Select = Console.ReadLine().ToUpper();
            } while (Select != "I" && Select != "U");
            if(Select=="I")isType = true;
            if (Select == "U") isType = false;
            Student student = new Student(fullName,isType);
            groupSettings.CreateStudents(student, GroupNo);
        }
        public static void ShowAllStudents()
        {
            groupSettings.GetAllStudents();
        }
        public static void GetGroupStudents()
        {
            GetGroups();
            Console.WriteLine("- - - - - - -\nEnter Group Name: ");
            string GroupNo = Console.ReadLine().ToUpper().Trim();
            groupSettings.GetGroupStudents(GroupNo);
        }
        public static void DeleteStudent()
        {
            Console.Write("Enter Gropu Name ");
            string GroupNo = Console.ReadLine();
            Console.Write("Select Student ID: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            groupSettings.DeleteStudent(Id, GroupNo);


        }
    }
}






