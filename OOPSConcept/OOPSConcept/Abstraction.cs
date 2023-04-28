using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    //it will show the essential features and hide the complex data from user.
    //it will achieve with the help of abstract class and abstract method.
    //abstract class
    public abstract class Abstraction
    {
        //firstly use abstract keyword to create the  abstract class
        //we cannot create the object for the abstract class.
        //abstract and non-abstract method are present in the abstract class.
        public abstract void abstractmetod();

        public void nonabstractmethod()
        {
            Console.WriteLine("this is non abstract method");
        }
    }
}
