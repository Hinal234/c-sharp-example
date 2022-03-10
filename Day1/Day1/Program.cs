using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        Program()
        {
            //constructor
        }
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            //Console.WriteLine("Hello");
            Console.WriteLine(str1);
            //Access Modifier - public,private,internal,protected
            //class
            //string : Field
            //datatype

            int number = 100;
            Console.WriteLine(number);
            //c# is strongly type language
            //static type language -- override the value
            int firstnum;
            firstnum = 1020;
            Console.WriteLine(firstnum);
            firstnum = number;
            Console.WriteLine(firstnum);

            //int a, b, c = 100;
            // int a=10, b=20, c=20;

            //explicit typed
            //int x = 100;
            Int32 x = 100;
            Console.WriteLine(x);

            //implicit typed
            var j = 1000;
            Console.WriteLine(j);

            //var a=10, b=20, c=20 ;  -----Compiletime error


            //data-type:
            //-value type   -reference type
            //---value type : simple, enum, struct, nullable
            //---reference : class type , interface type, array type, delegate type

            //understanding different types of datatype:
            // -- uint float double long ulong decimal
            //uint gi = 100u;
            //float f = 10.25f;

            //default values for int boolean
            int im = default(int);
            bool bm = default(bool);
            Console.WriteLine(bm);
            Console.WriteLine(im);

            //Type Conversion

            int ip = 1234;
            float isaf = ip;
            Console.WriteLine(isaf);


            string s = "Message";
            char[] ch = { 'h', 'i', 'i' };
            string snew = new string(ch);
            Console.WriteLine(snew);
            foreach (char c in ch)
            {
                Console.WriteLine(c);
            }

            string s2 = @"test@gmail.com";
            Console.Write(s2);
            Console.WriteLine(s2);

            string s3 = "hii \n" + "Hello\n" + "value";
            Console.WriteLine(s3);

            String s4 = @"hi  hello value";
            Console.WriteLine(s4);

            string aname = "Dr." + "abjgfes" + "uewgdgev";
            string firstname = "abjgfes";
            string lastname = "uewgdgev";
            string personname = firstname + lastname;
            Console.WriteLine(personname);

            string fullname = $"Dr. {firstname} {lastname}";
            Console.WriteLine(fullname);

            int h = 10, k = 20;
            if (h < k)
            {
                Console.WriteLine(h + " is less");
            }

            Console.WriteLine("Enter Number");
            string userinput = Console.ReadLine();
            int numone = Convert.ToInt32(userinput);
            if (numone % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }

            string str2 = "Jamesbon";
            int l = str2.Length;
            if (l > 5)
            {
                Console.Write(str2.Substring(0, (int)(l / 2)) + " ");
                Console.WriteLine(str2.Substring((int)(l / 2)));
            }
            else
            {
                Console.WriteLine(str2);
            }

            Console.WriteLine("Enter Number");
            string userinput1 = Console.ReadLine();
            int numtwo = Convert.ToInt32(userinput1);
            int fact = 1;
            for (int i = 1; i <= numtwo; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is :" + fact);

            Console.WriteLine("Enter Number : ");
            string userinput2 = Console.ReadLine();
            int numb = Convert.ToInt32(userinput2);
            if (numb % 2 == 0)
            {
                Console.WriteLine(numb + " is Even");
            }
            else
            {
                Console.WriteLine(numb + " is Odd");
            }

            DateTime dt = new DateTime();
            Console.WriteLine(dt);

            DateTime dm2 = new DateTime(2022, 03, 08, 3, 10, 30, DateTimeKind.Utc);
            Console.WriteLine(dm2);

            Console.WriteLine(DateTime.MinValue.Ticks);
            Console.WriteLine(DateTime.MaxValue.Ticks);

            DateTime currentdateTime = DateTime.Now;
            Console.WriteLine(currentdateTime);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            DateTime currentDateTimeUTC = DateTime.UtcNow;
            Console.WriteLine(currentDateTimeUTC);

            var st = "4/4/2001";
            DateTime dt1;
            var isValidDate = DateTime.TryParse(st, out dt1);

            if (isValidDate)
            {
                Console.WriteLine(dt1);
            }
            else
            {
                Console.WriteLine("Entered date is invalid");
            }



            Console.WriteLine("Enter Your Birthdate:");
            DateTime birthdate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(birthdate);
            var year = today.Year - birthdate.Year;
            var month = today.Month - birthdate.Month;
            var day = today.Day - birthdate.Day;
            Console.WriteLine("Age is " + year + " Years " + month + " Months " + day + " Days .");


            Console.WriteLine("Enter Date:");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(date);
            string datestr = date.ToString("dd/MMM/yyyy");
            Console.WriteLine(datestr);

            //struct

            Person p = new Person();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);

            //Person person = new Person("aaa","bbb","ccc");

            //StringBuilder : System.Text Library
            // --- DataManipulation

            StringBuilder sb = new StringBuilder("Good Morning ", 20);
            // Initial Capacity of Memory is 16
            sb.Append("Hii");
            Console.WriteLine(sb);
            for (int i = 0; i < sb.Length; i++)
            {
                Console.WriteLine(sb[i]);
            }
            sb.Insert(5, "nnn");
            Console.WriteLine(sb);

            var m = sb.ToString();
            Console.WriteLine(m);

            sb.Remove(5, 3);
            Console.WriteLine(sb);

            sb.Replace("Morning", "Afternoon");
            Console.WriteLine(sb);

            Console.WriteLine("Heyy Please Enter your FullName :");
            string fullName = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(fullName);
            Console.WriteLine(stringBuilder);
            Console.WriteLine("Are you want to Append the name then enter text what you want to append: ");
            string append = Console.ReadLine();
            stringBuilder.Append(append);
            Console.WriteLine(stringBuilder);

            Struct1 strct = new Struct1("James", "Bond");
            Console.WriteLine(strct.FirstName);

            int a = 0; //value type
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.GetType() == typeof(int));
            string b = "Hii";
            Console.WriteLine(b.GetType());


            Nullable<int> nullable = null;
            Console.WriteLine(nullable);


            int? aa = null;

            int z = 6;
            switch (z % 2)
            {
                case 0: aa = 1; break;
                case 1: aa = 2; break;
                default: aa = 3; break;
            }
            Console.WriteLine(aa);
            Customer customer = new Customer("hinal", 12, 25000, 2000);

        }
    }
    struct Person
    {
        public string Name;
        public string FirstName;
        public string LastName;

        public Person(string Name, string FirstName, string LastName)
        {
            this.Name = Name;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public static Person GetDetails()
        {
            return new Person();
        }
    }
    struct Struct1
    {
        public string FirstName;
        public string LastName;

        public Struct1(string FirstName,string LastName)
        {
            this.FirstName=FirstName;
            this.LastName= LastName;
        }
        public static Struct1 getStruct1()
        {
            return new Struct1();
        }

    }

    struct Customer
    {
        public string name;
        public int age;
        public int balance;
        public double loanAmount;



        public Customer(string name, int age, int balance, double loanAmount)
        {
            this.name = name;
            this.age = age;
            this.balance = balance;
            this.loanAmount = loanAmount;

        }
        public double getAmount()
        {
            return this.loanAmount;
        }
        public void setLoan()
        {
            switch (age)
            {
                case int i when i > 0 && i < 25: this.loanAmount += balance * 0.2; break;
                case int i when i > 25 && i < 45: this.loanAmount += balance * 0.35; break;
                case int i when i > 45: this.loanAmount += balance * 0.5; break;
                default: Console.WriteLine("Incorrect Value Entered"); break;
            }
        }
    }

}
