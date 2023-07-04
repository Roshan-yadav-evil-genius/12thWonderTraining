namespace InterfaceTypes
{
    public interface IDatabase
    {

        string Username { get; set; }
        string Password { get; set; }

        bool Add();
        void Update();
        void Delete();

        static void Info()
        {
            Console.WriteLine("Users Database Created By 12thWonder on 2023-05-01");
        }
        void Filter();
    }
    class BaseClass : IDatabase

    {
        public BaseClass()
        {

            Username = "12thWonder";
            Password = "123456";
        }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool Add()
        {
            Console.WriteLine("Add method called");
            return true;
        }
        public void Update()
        {
            Console.WriteLine("Update method called");
        }
        public void Delete()
        {
            Console.WriteLine("Delete method called");
        }
        public void Filter()
        {
            Console.WriteLine("Filter method called");
        }

        public void Execute(string[] args)
        {
            // interface is a reference type that contains only the signatures of methods, properties, events or indexers.
            // interface documentation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/interface  

            Console.WriteLine(Username);
            Console.WriteLine(Password);
            Add();
            Update();
            Delete();
            Filter();

        }
    }
}