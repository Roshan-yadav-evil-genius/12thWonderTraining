using System;

namespace LtestCsharpVersionCode.RefrenceType
{
    internal class ArrayType
    {
        public void Execute(string[] args)
        {
            // Array Type documentation: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/

            // You can store multiple variables of the same type in an array data structure. You declare an array by specifying the type of its elements. If you want the array to store elements of any type, you can specify object as its type. In the unified type system of C#, all types, predefined and user-defined, reference types and value types, inherit directly or indirectly from Object.

            int[] id = { 1, 2, 3, 4, 5 };

            Console.WriteLine($"id: {id}, Length: {id.Length}, Rank: {id.Rank}, IsFixedSize: {id.IsFixedSize}, IsReadOnly: {id.IsReadOnly}, IsSynchronized: {id.IsSynchronized},");

            // Length return the total number of elements in all the dimensions of the Array.
            // Rank returns the number of dimensions (also called axes) of the Array.
            // IsFixedSize returns a value indicating whether the Array has a fixed size.
            // IsReadOnly returns a value indicating whether the Array is read-only.
            // IsSynchronized returns a value indicating whether access to the Array is synchronized (thread safe).

            int[] id2 = new int[5];
            id2[0] = 1;
            id2[1] = 2;
            Console.WriteLine($"id2: {id2}, Length: {id2.Length}, Rank: {id2.Rank}, IsFixedSize: {id2.IsFixedSize}, IsReadOnly: {id2.IsReadOnly}, IsSynchronized: {id2.IsSynchronized},");

            int[] id3 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"id3: {id3}, Length: {id3.Length}, Rank: {id3.Rank}, IsFixedSize: {id3.IsFixedSize}, IsReadOnly: {id3.IsReadOnly}, IsSynchronized: {id3.IsSynchronized},");

            int[,] id4 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine($"id4: {id4}, Length: {id4.Length}, Rank: {id4.Rank}, IsFixedSize: {id4.IsFixedSize}, IsReadOnly: {id4.IsReadOnly}, IsSynchronized: {id4.IsSynchronized},");

            int[,] id5 = new int[2, 2];
            Console.WriteLine($"id5: {id5}, Length: {id5.Length}, Rank: {id5.Rank}, IsFixedSize: {id5.IsFixedSize}, IsReadOnly: {id5.IsReadOnly}, IsSynchronized: {id5.IsSynchronized},");

//WeakReference never iincrese size of array 
            // Array Methods
            // Clear

            // Copy
            // CopyTo
            // IndexOf
            // Reverse
            // Sort

        }
    }
}
