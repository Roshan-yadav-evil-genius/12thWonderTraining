using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LtestCsharpVersionCode.TypeSystem
{
    // public class GenericList<T>
    // {
    //     public void Add(T input) { }
    // }

    public class Calculator<T>
    {

        public static void showBoth(T first, T second)
        {
            Console.Write(first);
            Console.WriteLine(second);

        }
    }
    internal class GenericsType
    {

        public void Execute()
        {
            Calculator<int>.showBoth(1, 2);
            Calculator<string>.showBoth("Roshan", "Yadav");
            Calculator<bool>.showBoth(true, false);
        }
    }
}
