using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public interface Age
    {
        void get_age(DateTime date);
    }
    public class AgeCalc : Age
    {   
        public void get_age(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Subtract(dob).Days;
            age = age / 365;
            Console.WriteLine(age);
        }
    }
    public interface Vehicle
    {
        void car();
    }
    public class Drive : Vehicle
    {
        public void car()
        {
            Console.WriteLine("car Interface");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Drive();
            vehicle.car();

            Age age = new AgeCalc();
            age.get_age(Convert.ToDateTime("4/4/2001"));

            //arrays
            int[] numbers = { 1, 2, 3, 3, 4, 5 };
            Console.WriteLine(numbers);
            //string names = new string[nu
            Console.WriteLine(numbers[0]);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum()); 

            string[] usernames = { "James", "Peter", "aaa", "bbb", "ccc" };
            int[] usersage = { 20, 30, 47, 35, 35 };
            for(int u=0; u < usernames.Length; u++)
            {
                for(int j=0; j < usersage.Length; j++)
                {
                    if (u == j)
                    {
                        Console.WriteLine(usernames[u] + "    " + usersage[j]);
                    }
                }
            } 
            string[] male = new string[10];
            string[] female = new string[10];
            string f = "female";
            string m = "male";

            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Gender : (female/male) ");
            string gender = Console.ReadLine();
            if(gender.Equals(f))
            {
            //female = female.Append(name);
            Console.WriteLine(female);
            }
            else if(gender.Equals(m)) {
            male.Append(name);
            Console.WriteLine(male);
            }
            else
            {
                Console.WriteLine("Please enter gendre");
            } 

            int[] IntArray = new int[10] { 1, 3, 5, 7, 11, 13, 17, 19, 23, 31 };

            int target = 5;
            int pos = Array.BinarySearch(IntArray, target);
            if (pos >= 0)
                Console.WriteLine($"Item {IntArray[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine("Item not found");


            int[] arr = new int[5];
            Console.Write("Input 10 elements :");
            for (int a = 0; a < 10; a++)
            {
                Console.Write("element{0} : ", a);
                arr[a] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Elements in array are: ");
            for (int b = 0; b < 10; b++)
            {
                Console.Write("{0}  ", arr[b]);
            }
            Console.Write("\n");
            

             int[] arrone = new int[5];
            //System.collection
            int[] ar = { 10, 20, 30, 40 };
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add('a');
            al.Add(null);
            al.Add(10.20);
            al.Add(30);
            //size is increasing dynamically plus Helps to add differents types of data
            Console.WriteLine(al[0]);
            foreach (var num in al)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("--------");
            al.RemoveAt(1);
            al.Remove(30);
            Console.WriteLine(al.Contains(30));
            al.AddRange(ar);

            foreach (var num in al)
            {
                Console.WriteLine(num);
            }

            Queue queue = new Queue();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Dequeue();

            foreach (var num in queue)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Contains(10));
            Console.WriteLine(queue.Contains(20));
            Console.WriteLine(queue.Count);
            //Collections

            var numberlist = new List<int>();
            numberlist.Add(10);
            numberlist.Add(20);
            numberlist.Add(30);
            numberlist.Add(40);
            numberlist.Add(50);

            Console.WriteLine(numberlist.Count);
            Console.WriteLine(numberlist[2]);

            int[] arrtwo = { 1, 2, 3, 4, 5, 6 };
            numberlist.AddRange(arrone);
            foreach (var num in numberlist)
            {

                Console.WriteLine(num);
            }

            var customers = new List<Customer>()
            {
                new Customer(){ Id=1, Fname="James"},
                new Customer(){ Id=2, Fname="Peter"}
            };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + customer.Fname);

            }

            Console.WriteLine("-----Task-----");

            var person = new List<Customer>()
            {
                new Customer(){Id=1, Fname="James", Lname="Bond"},
                new Customer(){ Id=2, Fname="Peter",Lname="rich"}
            };

            Console.WriteLine("Enetr Id in Which You can Update");
            String ss = Console.ReadLine();
            int i = Convert.ToInt32(ss);
            foreach (var cust in customers)
            {
                if (i == cust.Id)
                {
                    Console.WriteLine("Enter Name:");
                    String s1 = Console.ReadLine();
                    cust.Fname = s1;
                }
                //Console.WriteLine(cust.Fname);
                Console.WriteLine(cust.Id + cust.Fname);

            }
            //Generic
            Console.WriteLine("-----GENERIC-----");
            DtStation<int> dtStation = new DtStation<int>();
            dtStation.Trans = 1000;

            KeyValue<String, String> keyValue = new KeyValue<String, String>();
            keyValue.Key = "id";
            keyValue.Value = "1";
            Console.WriteLine(keyValue.Key + " " + keyValue.Value);

            Console.WriteLine("---SORTED LIST----");
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(1, "James");
            list.Add(2, "Peter");
            foreach (var kvp in list)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            var container = new List<container>()
            {
                new container(){from="usa",to="uk",cost=100},
                new container(){from="india",to="usa",cost=6000},
                new container(){from="uk",to="india",cost=4000}
            };
            Console.WriteLine("enter from dest");
            String from = Console.ReadLine();
            Console.WriteLine("enter to dest");
            String to = Console.ReadLine();
            foreach (var item in container)
            {
                if (from == item.from && to == item.to)
                {
                    Console.WriteLine("cost = " + item.cost);
                    Console.WriteLine("from = " + item.from + " " + "to = " + item.to + " " + "cost = " + item.cost);
                    break;
                }
                else if (from == item.from && to == item.to)
                {
                    Console.WriteLine("cost = " + item.cost);
                    Console.WriteLine("from = " + item.from + " " + "to = " + item.to + " " + "cost = " + item.cost);
                    break;
                }
                else if (from == item.from && to == item.to)
                {
                    Console.WriteLine("cost = " + item.cost);
                    Console.WriteLine("from = " + item.from + " " + "to = " + item.to + " " + "cost = " + item.cost);
                    break;
                }
                else
                {
                    Console.WriteLine("plz Entre Valid Destination :");
                    break;
                }

            }

            IDictionary<int, string> dnum = new Dictionary<int, string>();
            dnum.Add(1, "James");
            dnum.Add(2, "Peter");
            dnum.Add(3, " ");
            dnum.Add(4, "AAA");

            var portdetail = new List<portdetail>()
            {
                new portdetail(){from="usa",to="uk",cost=100},
                new portdetail(){from="india",to="usa",cost=6000},
                new portdetail(){from="uk",to="india",cost=4000}

            };


            foreach (KeyValuePair<int, string> kvp in dnum)
            {
                Console.WriteLine("Key:{0}, Value:{1}", kvp.Key, kvp.Value);
            }

            IDictionary<int, string> port = new Dictionary<int, string>();
            port.Add(1, "Port1");
            port.Add(2, "Port2");
            port.Add(3, "Port3");
            port.Add(4, "Port4");
            port.Add(5, "Port5");
            port.Add(6, "Port6");



            IDictionary<int, string> data = new Dictionary<int, string>();
            data.Add(1, "usa");
            data.Add(2, "uk");
            data.Add(3, "india");
            Console.WriteLine("enter from destination");
            string str = Console.ReadLine();
            Console.WriteLine("enter to destination");
            string str0 = Console.ReadLine();

            foreach (KeyValuePair<int, string> kvp in data)
            {
                if (str == str0)
                {
                    Console.WriteLine("from and to detination not same so enter right from and end destination");
                    break;
                }
                if (str == kvp.Value)
                {
                    Console.WriteLine("from destination port = " + kvp.Key);
                }
                if (str0 == kvp.Value)
                {
                    Console.WriteLine("to destination port = " + kvp.Key);

                }

            }


        }
    }
    class DtStation<T>
    {
        public T Trans { get; set; }
    }
    class KeyValue<Tkey, Tvalue>
    {
        public Tkey Key { get; set; }
        public Tvalue Value { get; set; }
    }
    public class container
    {
        public string from { get; set; }
        public string to { get; set; }
        public int cost { get; set; }

    }
    public class portdetail
    {
        public int id { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public int cost { get; set; }
    }
    enum months
    {
        January,
        February,
        March
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Fname { get; set; }

        public string Lname { get; set; }
    }
}


