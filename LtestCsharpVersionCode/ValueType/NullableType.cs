using System;


namespace LtestCsharpVersionCode.ValueType
{
    internal class NullableType
    {
        public void Execute()
        {

            // old method to implement Nullable type
            Nullable<int> nullableInt2 = null;

            // Short Hand to implement Nullable type
            int? nullableInt = null;

            Console.WriteLine("Nullable<int> nullableInt2 = null; " + nullableInt2);
            Console.WriteLine("int? nullableInt = null; " + nullableInt);

        }
    }
}
