using ConsoleApp1.Enum;
using ConsoleApp1.Models;
using ConsoleApp1.Interface.IGroup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Group = ConsoleApp1.Models.Group;

namespace ConsoleApp1.Settings
{
    internal class GroupSettings : IGroupSettings
    {
        
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;
        public void CreateGroup(Categories category,bool isOnline)
        {
            Group group = new Group(category,isOnline);
            
           
            if(Groups.Count == 0)
            {
                _groups.Add(group);
            }
            foreach (var item in Groups)
            {
                if (group.No.ToLower().Trim() != item.No.ToLower().Trim())
                {
                    _groups.Add(group);
                    Console.WriteLine(group.No+" Sucessfully Created ");
                }
                else { Console.WriteLine("Not Created Group."); }
            }
            
        }

        public void CreateStudents()
        {
           
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public void EditGroupNo(string OldNo,string NewNo)
        {
            if (FindGroup(NewNo) == null)
            {
                Group gr = FindGroup(OldNo);
                if (gr != null)
                {
                    gr.No = NewNo.ToUpper().Trim();
                    Console.WriteLine($"{gr.No} Sucessfully Changed");
                }
                else Console.WriteLine($"There is no {OldNo} name in System.");
            }
            else Console.WriteLine("There is Group this name.pls check another Group Name.");
        }
        public Group FindGroup(string no)
        {
            foreach (Group gr in Groups)
            {
                if (gr.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return gr;
                }
            }
            return null;
        }
        public void GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public void GetAllGroupList()
        {
            if(Groups.Count > 0)
            {
                foreach (Group group in Groups)
                {
                    Console.WriteLine(group);
                }
            }
            else
            {
                Console.WriteLine("There is no group in System");
            }
        }

        public void GetGroupStudents(string GroupNo)
        {
            Group group = FindGroup(GroupNo);
            if (group != null)
            {
                foreach(Student student in group.students)
                {
                    Console.WriteLine(student);
                }
            }
            else Console.WriteLine($"There is no {GroupNo}");
        }
    }
}
