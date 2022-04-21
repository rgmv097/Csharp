using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Admin:User
    {
        
      public  bool IsSuperadmin;
       public string Section;

       
        public Admin(string username,string password):base(username,password)
        {

        }
        public void  ShowInfo()
        {
            Console.WriteLine($"\nSection:{Section}\nName:{Username}\nPassword:{Password}\nSuperAdmin:{IsSuperadmin}");
        }
    }
}
