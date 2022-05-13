using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        public static int Id;
        public  string FullName;
        public  string GroupNo;
        public bool IsType;
        static Student()
        {

            Id = 1;
        }
        public Student(string fullName, string groupNo, bool isType)
        {
            FullName = fullName;
            GroupNo = groupNo;
            IsType = isType;
            Id++;


        }

        public override string ToString()
        {
            return $"Fullname: {FullName}, Group No: {GroupNo}, Status: {(IsType ? "Zemanetli" : "Zemanetsiz")}";
        }
    }
}
