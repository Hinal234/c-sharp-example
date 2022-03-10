using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Program
    {
        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        static void Main(string[] args)
        {
            char y = 'y';
            char n = 'n';
            Program program = new Program();

            String AutoPassword = program.CreatePassword(7);
            //Console.WriteLine(AutoPassword);
            Random rnd = new Random();
            int id = rnd.Next();

            Console.WriteLine("Enter FirstName :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name : ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(number);
            Console.WriteLine(" FOR  FIRST TIME LOGIN");
            Console.WriteLine("Enter UserName : ");
            double username = Convert.ToDouble(Console.ReadLine());
            if (username.Equals(number))
            {
                Console.WriteLine("Your Password is :" + AutoPassword);
                Console.WriteLine("YOur Id IS : " + id);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Username");
            }
            Console.WriteLine("For Second Time Login:");
            Console.WriteLine("Enter UserName : ");
            double username1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Password : ");
            string pwd = Console.ReadLine();

            if (username1.Equals(username) && pwd.Equals(AutoPassword))
            {
                Console.WriteLine("WelCome");
                Console.WriteLine("if You Wnat to Forget your Password?(y/n)");
                char a = Convert.ToChar(Console.ReadLine());
                if (a.Equals(y))
                {
                    string a1 = "aa", a2 = "123", a3 = "a1";
                    Console.WriteLine("Please Give Answer the Secret Questions:");
                    Console.WriteLine("Questions 1 : What is your school Name:");
                    string q1 = Console.ReadLine();
                    Console.WriteLine("Question 2: Enter ZIP Code: ");
                    string q2 = Console.ReadLine();
                    Console.WriteLine("Question 3: What is Your username: ");
                    string q3 = Console.ReadLine();
                    if (q1.Equals(a1) && q2.Equals(a2) && q3.Equals(a3))
                    {
                        Console.WriteLine("Enter New Password: ");
                        string newPassword = Console.ReadLine();
                        Console.WriteLine("Your Password is Upadated Successfullly");
                        Console.WriteLine(newPassword);
                    }
                    else
                    {
                        Console.WriteLine("Please Entre valid Answer");
                    }
                }
                else
                {
                    Console.WriteLine("Bye");
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Username And Password");
            }

            IDictionary<int, string> port = new Dictionary<int, string>();
            port.Add(1, "Port1");
            port.Add(2, "Port2");
            port.Add(3, "Port3");
            port.Add(4, "Port4");
            port.Add(5, "Port5");
            port.Add(6, "Port6");

            Console.WriteLine("Enter Port ID :  ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter From Place:");
            string from = Console.ReadLine();
            Console.WriteLine("Enter Destination:");
            string to = Console.ReadLine();
            Console.WriteLine("If You Want to Change From or Destination Place Then Please Enter PortID");

            foreach (KeyValuePair<int, string> kvp in port)
            {

                if (kvp.Key == p)
                {
                    Console.WriteLine("Enter new Destination:");
                    string dest = Console.ReadLine();
                    Console.WriteLine("New Destination is: " + dest);
                }
            }

 
        }
    }
}
