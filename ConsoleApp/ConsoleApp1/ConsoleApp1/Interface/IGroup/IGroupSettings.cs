using ConsoleApp1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interface.IGroup
{
    internal interface IGroupSettings
    {
        void CreateGroup(Categories category, bool isOnline);
        void GetAllGroupList();

        void EditGroupNo(string OldNo, string NewNo);
        void GetGroupStudents(string GroupNo);
        void GetAllStudents();
        void CreateStudents();
        void DeleteStudent();
    }
}
