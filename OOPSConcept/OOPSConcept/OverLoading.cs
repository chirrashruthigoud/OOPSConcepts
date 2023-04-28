using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{  // polymorphism means  many form and there are two types of polymorphism
    //Run-time polymorphism =>method overriding
    //Compile type polymorphism =>method overloading


    public class OverLoading
    {  //compile time=> it Contain many function or methods with different parameters
        public void MethodOverloading()
        {
            Console.WriteLine("without parameter");
        }
        public void MethodOverloading(int num)
        {
            Console.WriteLine("with one parameters");
        }
        public void MethodOverloading(int num, string name)
        {
            
            Console.WriteLine("with two parameter");
        }
    }
}
