using System;

namespace UserLogin
{
    class Program
    {
        // created globally
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }


        public static void Register()
        { // static so we can use it in main
            Console.WriteLine("enter username");
            username = Console.ReadLine();
            Console.WriteLine("enter password");
            password = Console.ReadLine(); Console.WriteLine("registration complete\n ___________________________");
        }

        public static void Login()
        { // static so we can use it in main
            Console.WriteLine("enter username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("enter password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("invalid password, try again");
                }
            }
            else
            {
                Console.WriteLine("invalid username, try again");
            }


        }
    }

}