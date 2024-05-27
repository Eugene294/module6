using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class User
    {
        private int age;
        private string login;
        private string mail;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    age = value;
                }
            }
        }


        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                if (login.Length < 3)
                {
                    Console.WriteLine("Логин должен быть не меньше 3 символов");
                }
                else
                {
                    login = value;
                }
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                if (!value.Contains('@'))
                {
                    Console.WriteLine("Возраст должен быть не меньше 18");
                }
                else
                {
                    mail = value;
                }
            }
        }
    }
}
