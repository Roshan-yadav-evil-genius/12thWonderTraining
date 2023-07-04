using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // var SimpleType = new SimpleTypes.BaseClass();
            // SimpleType.Execute();
            // var NullableType = new NullableTypes.BaseClass();
            // NullableType.Execute();
            // var EnumType = new EnumTypes.BaseClass();
            // EnumType.Execute();
            // var StructType = new StructTypes.BaseClass();
            // StructType.Execute();
            // var TupleType = new TupleTypes.BaseClass();
            // TupleType.Execute();
            // var ArrayType = new ArrayTypes.BaseClass();
            // ArrayType.Execute(args);
            // var ClassType = new ClassTypes.BaseClass();
            // ClassType.Execute(args);
            // var DelegateType = new DelegateTypes.BaseClass();
            // DelegateType.Execute();
            // var InterfaceType = new InterfaceTypes.BaseClass();
            // InterfaceType.Execute(args);
            var UnicodeType = new UnicodeTypes.BaseClass();
            UnicodeType.Execute(args);

        }
    }
}

