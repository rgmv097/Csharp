using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class User
    {

        private string _username;
        private string _password;
        
        public User(string username, string password)
        {

            Password = password;
            Username = username;

        }
        public string Username
        {
            get {
                return _username;
            }

            set {
                if (value.Length > 6)
                {
                    _username = value;
                    
                }
                else
                {
                    Console.WriteLine("USERNAME uzunlugu 6 dan boyuk olmalidir");

                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                bool num1 = false;
                bool num2 = false;
                
                if (value.Length > 6)
                {
                    for (int i = 0; i < value.Length; i++)
                    {


                        if (char.IsNumber(value[i]))
                        {
                            num1 = true;
                        }
                        if (char.IsUpper(value[i]))
                        {
                            num2 = true;
                        }

                    }
                    if(num1 == true && num2 == true)
                    {
                        _password = value;
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("ena z 1 boyuk herf ve 1 reqem olmalidir");
                         
                    }
                }
                else
                {
                    Console.WriteLine("PASSWORD uzunlugu 6 dan boyuk olmaldiir");
                }

            }
        }
    }


    }


