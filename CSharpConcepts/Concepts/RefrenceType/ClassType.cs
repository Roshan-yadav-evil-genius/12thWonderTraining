using System;


namespace CSharpConcepts.Concepts.RefrenceType
{
    internal class ClassType
    {
        public void Execute(string[] args)
        {
            // class is a reference type that can contain data members that include constants, fields, methods, properties, indexers, constructors, destructors, and events.

            Database db = new Database("admin", "admin");
            db.Connect();

            Console.WriteLine(db);

            Database nc = new Database("root", "root");
            nc.Connect();

            var obj1 = new Person
            {
                Name = "Roshan",
                Age = 18
            };
            obj1.SayHello();

            Person obj2 = new Person();
            obj2.Name = "Satyam";
            obj2.Age = 18;
            obj2.SayHello();

        }
    }
    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, {Name}. Your age is {Age}");
        }
    }
    class Database
    {
        string? UserName;
        string? Password;
        public Database(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public void Connect()
        {
            Console.WriteLine($"Connecting to database with UserName: {UserName}, Password: {Password}");
            if (UserName == "admin" && Password == "admin")
            {
                Console.WriteLine($"Connected to database with UserName: {UserName}, Password: {Password}");
            }
            else
            {
                Console.WriteLine($"Invalid UserName: {UserName}, Password: {Password}");
            }
        }

        public override string ToString()
        {
            return $"12thWonder Database Handling System";
        }
    }
}
