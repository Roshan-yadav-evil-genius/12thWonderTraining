using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsConcept
{
    public class User : IComparable<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int CompareTo(User other)
        {
            if (this.Id < other.Id)
            {
                return -1;
            }
            else if (this.Id > other.Id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
    class CompareNames : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (x.Id < y.Id)
            {
                return -1;
            }
            else if (x.Id > y.Id)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    class OperationOn<T>
    {

        public void Add(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.Write("Addition Output = ");
            Console.WriteLine(num1 + num2);
        }
    }
    internal class Program
    {
        public static int CompareByName(User s1, User s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }

        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Roshan Yadav");
            ht.Add("Age", 22);
            ht.Add("Salary", 20000.0);

            Console.WriteLine(ht["name"]);
            Console.WriteLine("Name".GetHashCode());
            Console.WriteLine("name".GetHashCode());

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key]);
            }


            //GenericUriParser Collections
            Console.WriteLine("-----------List Generic------------");

            List<User> list = new List<User>() {
                new User(1, "john", "john@gmail.com") ,
                new User(2, "amit", "amit@gmail.com")
            };
            list.Add(new User(3, "master", "master@gmail.com"));
            list.Add(new User(4, "main", "main@gmail.com"));
            list.Add(new User(5, "teacher", "teacher@gmail.com"));
            list.Add(new User(6, "accoutant", "accoutant@gmail.com"));

            Console.WriteLine("List Count : " + list.Count);
            Console.WriteLine(list[2]);
            list.Insert(2, new User(7, "worker", "teacher@gmail.com"));
            list.Remove(list[2]);

            foreach (User user in list)
            {
                Console.WriteLine(user.Id + " " + user.Name + " " + user.Email);
            }

            //Generics 
            OperationOn<int> op = new OperationOn<int>();
            op.Add(2, 4);

            //Dictionary
            Console.WriteLine("-----------Dictionary------------");
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("name", "Guddu");
            dic.Add("email", "Guddu@gmail.com");
            dic.Add("PhnNo", 8476868560);

            foreach (var key in dic.Keys)
            {
                Console.WriteLine(key + " " + dic[key]);
            }

            Console.WriteLine("-----------IComparable------------");
            List<int> marks = new List<int>() { 40, 20, 90, 10, 30 };
            Console.Write("List : ");
            marks.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
            marks.Sort();
            Console.Write("Sorted List : ");
            marks.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            List<User> users = new List<User>() {
                new User(5, "john", "john@gmail.com") ,
                new User(2, "amit", "amit@gmail.com") ,
                new User(9, "shark", "shark@gmail.com") ,
                new User(0, "master", "master@gmail.com")};
            Console.Write("List : ");
            users.ForEach(x => Console.Write(x.Id + " "));
            Console.WriteLine();
            users.Sort();
            Console.Write("Sorted List : ");
            users.ForEach(x => Console.Write(x.Id + " "));
            Console.WriteLine(); 
            Console.Write("Reversed List : ");
            users.Reverse();
            users.ForEach(x => Console.Write(x.Id + " "));
            Console.WriteLine("\n[+] Comparing BY Names");
            CompareNames obj = new CompareNames();
            users.Sort(obj);
            Console.Write("Sorted List : ");
            users.ForEach(x => Console.Write(x.Id + " "));
            users.Reverse();
            Console.WriteLine("\n[+] By Using 4th overload");
            users.Sort(1,2,obj);
            Console.Write("Sorted List : ");
            users.ForEach(x => Console.Write(x.Id + " "));
            Console.WriteLine("\n[+] By Using 2nd overload (Delegate)");
            Comparison<User> compareDelegate = new Comparison<User>(CompareByName);
            //types is only allowed to pass as parameter not method to overcome this we use delegate
            users.Sort(compareDelegate);
            Console.Write("Sorted List : ");
            users.ForEach(x => Console.Write(x.Name + " "));
            //Byte Anonymous Method
            users.Sort(delegate (User s1,User s2) { return s1.Name.CompareTo(s2.Name); });
            Console.Write("\nSorted List : ");
            users.ForEach(x => Console.Write(x.Name + " "));
            // By LAmbda function
            users.Sort(( s1, s2)=>s1.Name.CompareTo(s2.Name));
            Console.Write("\nSorted List : ");
            users.ForEach(x => Console.Write(x.Name + " "));
            // By Direct passing methodname
            users.Sort(CompareByName);
            Console.Write("\nSorted List : ");
            users.ForEach(x => Console.Write(x.Name + " "));
            Console.ReadLine();
        }

    }
}
