using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{   //inheritance is totally dependent on derived class and base class /child or parent class
    //we are using colon :
<<<<<<< HEAD
    public class Inheritance : baseclass
=======
    public class Inheritance : baseclass  
>>>>>>> UC5_Inheritance
    {
        public Inheritance()  //paresentclass
        {
            Console.WriteLine("this my parent class");
        }
        public void Class()
        {
            Console.WriteLine("this is my method for parent clas");
        }
    }
    public class baseclass   //child class
    {
        public string name;
        public void Testname()
        {
            Console.WriteLine("this a base class");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> UC5_Inheritance
