using ConsoleApp1.Enum;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    internal class Group
    {
        public string No;
        public Categories Category;
        public bool IsOnline;
        public byte Limit;
        public List<Student> students;
        public static int Count;
        static Group()
        {
            Count = 324;          
        }
        public Group(Categories category, bool isOnline)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P-" + Count;
                    break;
                case Categories.Design:
                    No = $"D-" + Count;
                    break;
                case Categories.System_Adminstration:
                    No = $"SA-" + Count;
                    break;
                case Categories.English:
                    No = $"EN-" + Count;
                    break;
                case Categories.Digital_Marketing:
                    No = $"DM-" + Count;
                    break;
                default:
                    break;
            }
            ++Count;
            if (isOnline == true)
            {
                Limit = 15;
            }
            else { Limit = 10; }
            
            
            IsOnline = isOnline;
            Category = category;
            students = new List<Student>();
        }
        public override string ToString()
        {
            return $"Group No: {No}, Category: {Category}";
        }
    }
}
