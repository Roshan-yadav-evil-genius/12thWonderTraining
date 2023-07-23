using System;


namespace LtestCsharpVersionCode.RefrenceType
{

    public delegate int AddDelegate(int a, int b);
    public delegate void SubDelegate(int a, int b);
    public delegate int MulDelegate(int a, int b);
    internal class DelegateType
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add method called");
            return a + b;
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Sub method called");
            Console.WriteLine(a - b);
        }
        public int Mul(int a, int b)
        {
            Console.WriteLine("Mul method called");
            return a * b;
        }
        public void Execute()
        {
            // delegate is a type that represents references to methods with a particular parameter list and return type.
            // delegate documentation: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/delegate

            var adding = new AddDelegate(Add);
            var subtracting = new SubDelegate(Sub);
            var multiplying = new MulDelegate(Mul);

            Console.WriteLine(adding(1, 2));
            Console.WriteLine(adding.Invoke(1, 2));

            AddDelegate addDelegate = Add;
            Console.WriteLine(addDelegate(1, 2));

            AddDelegate addMulDelegate2 = Add;
            addMulDelegate2 += Mul;
            Console.WriteLine(addMulDelegate2(1, 2));
        }
    }

}
