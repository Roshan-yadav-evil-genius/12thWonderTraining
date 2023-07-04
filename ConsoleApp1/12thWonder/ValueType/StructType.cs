namespace StructTypes
{
    class BaseClass
    {
        struct Programmer
        {
            public string Name;
            public int Age;
            public string Language;
            public Programmer(string name, int age, string language)
            {
                Name = name;
                Age = age;
                Language = language;
            }
        }
        // struct without constructor
        struct Employee
        {
            public string Name;
            public int Age;
            public string Department;
        }
        public void Execute()
        {
            // Struct is a value type that is used to encapsulate small groups of related variables
            Programmer p1 = new()
            {
                Name = "John",
                Age = 30,
                Language = "C#"
            };
            Console.WriteLine("p1.Name = {0}, p1.Age = {1}, p1.Language = {2}", p1.Name, p1.Age, p1.Language);

            var p2 = new Programmer("Jane", 25, "Java");
            Console.WriteLine("p2.Name = {0}, p2.Age = {1}, p2.Language = {2}", p2.Name, p2.Age, p2.Language);

            // struct without constructor

            Employee e1 = new()
            {
                Name = "John",
                Age = 30,
                Department = "IT"
            };
            Console.WriteLine("e1.Name = {0}, e1.Age = {1}, e1.Department = {2}", e1.Name, e1.Age, e1.Department);

            // var e2 = new Employee(Name = "Jane",Age = 25,Department = "HR") // without constructor not possible



        }
    }
}