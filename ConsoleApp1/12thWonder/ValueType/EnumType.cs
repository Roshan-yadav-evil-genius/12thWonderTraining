namespace EnumTypes
{
    class BaseClass
    {
        enum CarsInShowRoom
        {
            BMW,
            Audi,
            Mercedes,
            Toyota,
            Honda
        }
        // enum documentation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum

        public void Execute()
        {
            // Enum is a value type that is used to define a set of named constants
            Console.WriteLine("(CarsInShowRoom)4 = {0}",(CarsInShowRoom)4);
            Console.WriteLine("(int)CarsInShowRoom.Honda = {0}",(int)CarsInShowRoom.Honda);
            Console.WriteLine("(CarsInShowRoom)9 = {0}",(CarsInShowRoom)9);


        }
    }
}