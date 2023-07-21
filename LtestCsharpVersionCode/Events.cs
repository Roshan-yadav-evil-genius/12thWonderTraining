using CSharpConcepts.Concepts.Program;
using System;


namespace CSharpConcepts.Concepts
{
    namespace Program
    {
        public delegate void Transformer(int x);

        class Notification
        {
            public event Transformer transformer;

            public void NotifyOnCall(int x)
            {
                if (transformer != null)
                {
                    transformer(x);
                }
            }
        }

        class User1
        {

            public static void Xhandler(int x)
            {
                Console.WriteLine("Event receiveed By User1");
            }
        }
        class User2
        {
            public static void Yhandler(int x)
            {
                Console.WriteLine("Event receiveed By User2");
            }
        }

    }
    internal class Events
    {
        public void Execute()
        {
            Notification notification = new();
            notification.transformer += User1.Xhandler;
            notification.transformer += User2.Yhandler;
            notification.NotifyOnCall(1);

            string number = string.Empty;
            number = Console.ReadLine();
            if ((number is string) & (number is not null))
            {
                Console.WriteLine($"string {number}");
            }
            else
            {
                Console.WriteLine("Not Null");
            }
        }
    }
}
