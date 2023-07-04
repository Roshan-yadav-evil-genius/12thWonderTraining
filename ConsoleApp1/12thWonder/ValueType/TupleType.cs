using System.Security.Cryptography.X509Certificates;

namespace TupleTypes
{
    class BaseClass
    {
        public void Execute(){
            // Tuple Type documentation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples

            (int,double,float,string) tuple1 = (1,35.5,45.6f,"Roshan");
            Console.WriteLine($"tuple1: {tuple1}, tuple1.Item1: {tuple1.Item1}, tuple1.Item2: {tuple1.Item2}, tuple1.Item3: {tuple1.Item3}, tuple1.Item4: {tuple1.Item4}");


            (int ID,double Temp,float Hum,string User) tuple2 = (1,35.5,45.6f,"Roshan");
            Console.WriteLine($"tuple2: {tuple2}, tuple2.ID: {tuple2.ID}, tuple2.Temp: {tuple2.Temp}, tuple2.Hum: {tuple2.Hum}, tuple2.User: {tuple2.User}");
            
            var tuple3 = (ID:1,Temp:35.5,Hum:45.6f,User:"Roshan");
            Console.WriteLine($"tuple3: {tuple3}, tuple3.ID: {tuple3.ID}, tuple3.Temp: {tuple3.Temp}, tuple3.Hum: {tuple3.Hum}, tuple3.User: {tuple3.User}");

            var tuple4 = (233,"John",true,0.5);
            Console.WriteLine($"tuple4: {tuple4}, tuple4.Item1: {tuple4.Item1}, tuple4.Item2: {tuple4.Item2}, tuple4.Item3: {tuple4.Item3}, tuple4.Item4: {tuple4.Item4}");

            // One of the most common use cases of tuples is as a method return type. That is, instead of defining out method parameters, you can group method results in a tuple return type.
            int ID = 0;
            (int,string) AddUser(string Name,string designation){
                ID++;
                return (ID,Name);
            }
            Console.WriteLine($"AddUser: {AddUser("Roshan","Developer")}");
            Console.WriteLine($"AddUser: {AddUser("Satyam","Developer")}");
        }
    }
}