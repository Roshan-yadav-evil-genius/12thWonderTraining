using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Concepts.TypeSystem
{
    internal class AnonymousType
    {
        public void Execute()
        {
            var v = new { Amount = 108, Message = "Hello" };

            // Rest the mouse pointer over v.Amount and v.Message in the following
            // statement to verify that their inferred types are int and string.
            Console.WriteLine(v.Amount + v.Message);
        }
    }
}
