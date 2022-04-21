using System;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //string password =(Console.ReadLine());

            
            while (true)
            {

                Console.Write("Name daxil et:");
                string username=Console.ReadLine();
                Console.Write("Password daxil et:");
                string password=Console.ReadLine();

                Admin admin = new Admin(username, password);
                if (admin.Username != null && admin.Password != null)
                {
                    admin.IsSuperadmin = true;
                    admin.Section = "ADMIN PANEL";
                   admin.ShowInfo(); break;
                }
                
                admin.ShowInfo();
                Console.WriteLine();
                
                


            }




        }
    }
}
