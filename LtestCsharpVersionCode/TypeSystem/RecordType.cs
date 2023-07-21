using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtestCsharpVersionCode.TypeSystem
{
    // provides a concise way to declare immutable data types.Records are similar to classes, but they come with built-in features for value-based equality, immutability, and a straightforward syntax for creating data-only objects.

    // Records are particularly useful when dealing with immutable data models. Since records are immutable by default, once an instance of a record is created, its values cannot be changed. This makes records a great choice for representing data that should not be modified after creation.

    // records have built -in value - based equality.This means that two record instances with the same property values are considered equal, which is a common requirement for data models
    internal class RecordType
    {
        public record Person(string FirstName, string LastName, string[] PhoneNumbers);
        public readonly record struct Point(double X, double Y, double Z);

        public void Execute()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Roshan", "Yadav", phoneNumbers);
            Person person2 = new("Roshan", "Yadav", phoneNumbers);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person1.Equals(person2)); // output: True
            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False

            person1.PhoneNumbers[0] = "431";
            person1.PhoneNumbers[1] = "432";

            Console.WriteLine(person2.PhoneNumbers[0]); //they both share the same reference to the phoneNumbers array
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person1.Equals(person2)); // output: True
            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }

    }
}
