using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Group
    {
        public string No;
        public Categories Category;
        public bool IsOnline;
        public  byte Limit;
        public List<Student> students;
        public static int count;
        static Group()
        {
            count = 324;
        }
        public Group(Categories category, bool isOnline)
        {
            switch (category)
            {
                case Categories.Programming:
                    No = $"P-" + count;
                    break;
                case Categories.Design:
                    No = $"D-" + count;
                    break;
                case Categories.System_Adminstration:
                    No = $"SA-" + count;
                    break;
                case Categories.English:
                    No = $"EN-" + count;
                    break;
                case Categories.Digital_Marketing:
                    No = $"DM-" + count;
                    break;
                default:
                    break;
            }
            if (isOnline == true)
            {
                Limit = 15;
            }
            else { Limit = 10; }

            count++;
            IsOnline = isOnline;
            Category = category;
            students= new List<Student>();                
        }
        public override string ToString()
        {
            return $"Group No: {No}, Category: {Category}";
        }
    }
}
