using ConsoleApp1.Enum;
using ConsoleApp1.Interface.IGroup;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using Group = ConsoleApp1.Models.Group;

namespace ConsoleApp1.Settings
{
    internal class GroupSettings : IGroupSettings
    {

        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;
        public void CreateGroup(Categories category, bool isOnline)
        {
            Group group = new Group(category, isOnline);


            if (Groups.Count == 0)
            {
                _groups.Add(group);
                Console.WriteLine(group.No + " Sucessfully Created ");
                
            }
            else if (Groups.Count >0) {
                foreach (var item in Groups)
                {
                    if (group.No.ToLower().Trim() != item.No.ToLower().Trim())
                    {
                        Console.WriteLine($"{group.No} group created");
                        _groups.Add(group);
                        break;

                    }
                    else { Console.WriteLine("Not Created Group."); }
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void CreateStudents(Student student, string GroupNo)
        {

            if (Groups.Count > 0)
            {
                Group group = FindGroup(GroupNo);
                if (group != null)
                {
                    if (!string.IsNullOrEmpty(student.FullName) || !string.IsNullOrWhiteSpace(student.FullName))
                    {
                        if (group.students.Count < group.Limit)
                        {
                            Console.WriteLine($"{student.FullName} Added in Course");
                            group.students.Add(student);
                            
                        }
                        else
                        {
                            Console.WriteLine("Group is limit full");
                        }
                    }
                    else { Console.WriteLine("Pls enter Full Name.Don't Null Name"); }
                }
                else { Console.WriteLine($"There is no {GroupNo} name group in sytem"); }

            }
            else { Console.WriteLine("There is no Group"); }
        }

        public void DeleteStudent(int studentId, string GroupNo)
        {
            if (Group.Count > 0)

            {
                Group group = FindGroup(GroupNo);

                if (group is null)
                {
                    Console.WriteLine($"There is no {GroupNo} name Group");
                    return;
                }

                foreach (Student student in group.students)
                {
                    if (student.Id == studentId)
                    {
                        Console.WriteLine($"Sucessfull Deleted student: {student.Id} ");
                        group.students.Remove(student);

                        break;
                    }
                }
            }
            else { Console.WriteLine("There is no any Group"); }
        }

        public void EditGroupNo(string OldNo, string NewNo)
        {
            if (FindGroup(NewNo) == null)
            {
                Group group = FindGroup(OldNo);
                if (group != null)
                {
                    group.No = NewNo.ToUpper().Trim();
                    Console.WriteLine($"{group.No} Sucessfully Changed");
                }
                else { Console.WriteLine($"There is no {OldNo} name in System."); }
            }
            else { Console.WriteLine("There is Group this name.pls check another Group Name."); }
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in Groups)
            {
                if (group.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }


        public void GetAllGroupList()
        {
            if (Groups.Count > 0)
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

        public void GetAllStudents()
        {
            if (Groups.Count > 0)
            {
                foreach (Group item in Groups)
                {
                    if (item.students.Count > 0)
                    {
                        foreach (Student student in item.students)
                        {
                            Console.WriteLine($"FullName: {student.FullName}\nID: {student.Id}\nGroup No: {item.No}");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not any students in system");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Groups in System");
            }
        }

        public void GetGroupStudents(string GroupNo)
        {
            Group group = FindGroup(GroupNo);
            if (group != null)
            {
                foreach (Student student in group.students)
                {
                    Console.WriteLine(student);
                }
            }
            else Console.WriteLine($"There is no {GroupNo}");
        }


    }
}
