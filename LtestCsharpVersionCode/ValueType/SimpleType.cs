using System;


namespace LtestCsharpVersionCode.ValueType
{
    internal class SimpleType
    {
        public void Execute()
        {
            // List all types of data types
            bool isTrue = true; // bool refers to Boolean which is able to store true or false
            byte byteValue = 255; // byte is able to store 0 to 255
            sbyte sbyteValue = -128; // sbyte is able to store -128 to 127
            char charValue = 'a'; // char is able to store a single character
            decimal decimalValue = 1.0m; // decimal is able to store 28 to 29 digits
            double doubleValue = 1.0; // double is able to store 15 to 16 digits
            float floatValue = 1.0f; // float is able to store 7 digits
            int intValue = 1; // int is able to store -2,147,483,648 to 2,147,483,647
            uint uintValue = 1; // uint is able to store 0 to 4,294,967,295
            long longValue = 1; // long is able to store -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong ulongValue = 1; // ulong is able to store 0 to 18,446,744,073,709,551,615
            short shortValue = 1; // short is able to store -32,768 to 32,767
            ushort ushortValue = 1; // ushort is able to store 0 to 65,535
            string stringValue = "Hello World"; // string is able to store a string of characters


            Console.WriteLine("bool: " + isTrue + " LowerLimit: " + bool.FalseString + " UpperLimit: " + bool.TrueString);
            Console.WriteLine("byte: " + byteValue + " LowerLimit: " + byte.MinValue + " UpperLimit: " + byte.MaxValue);
            Console.WriteLine("sbyte: " + sbyteValue + " LowerLimit: " + sbyte.MinValue + " UpperLimit: " + sbyte.MaxValue);
            Console.WriteLine("char: " + charValue + " LowerLimit: " + char.MinValue + " UpperLimit: " + char.MaxValue);
            Console.WriteLine("decimal: " + decimalValue + " LowerLimit: " + decimal.MinValue + " UpperLimit: " + decimal.MaxValue);
            Console.WriteLine("double: " + doubleValue + " LowerLimit: " + double.MinValue + " UpperLimit: " + double.MaxValue);
            Console.WriteLine("float: " + floatValue + " LowerLimit: " + float.MinValue + " UpperLimit: " + float.MaxValue);
            Console.WriteLine("int: " + intValue + " LowerLimit: " + int.MinValue + " UpperLimit: " + int.MaxValue);
            Console.WriteLine("uint: " + uintValue + " LowerLimit: " + uint.MinValue + " UpperLimit: " + uint.MaxValue);
            Console.WriteLine("long: " + longValue + " LowerLimit: " + long.MinValue + " UpperLimit: " + long.MaxValue);
            Console.WriteLine("ulong: " + ulongValue + " LowerLimit: " + ulong.MinValue + " UpperLimit: " + ulong.MaxValue);
            Console.WriteLine("short: " + shortValue + " LowerLimit: " + short.MinValue + " UpperLimit: " + short.MaxValue);
            Console.WriteLine("ushort: " + ushortValue + " LowerLimit: " + ushort.MinValue + " UpperLimit: " + ushort.MaxValue);
            Console.WriteLine("string: " + stringValue + " LowerLimit: " + string.Empty + " UpperLimit: " + string.Empty);

            // Manipulation possible with object
            // object objectValue = new object(); // object is able to store any type of data type
            // or
            object objectValue = new(); // object is able to store any type of data type
            objectValue = 1;
            objectValue = "Hlo";
            Console.WriteLine("object: " + objectValue);

            // Manipulation not possible with var
            // var value =1;
            // value ="hlo";
            // Console.WriteLine("var: " + value);

        }
    }
}
