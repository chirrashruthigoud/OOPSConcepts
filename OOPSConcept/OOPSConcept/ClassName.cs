using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPSConcept
{
    public class Calculator: InterfaceType
    {
        // Non-parameterized method
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // Parameterized method
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public void WithoutImplementionmethod()
        {
            Console.WriteLine("this is my classname");
        }
    }
}

