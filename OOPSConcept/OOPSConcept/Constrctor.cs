using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Constrctor
    {
        //Constructor don't have any return type
        //Name should be same as the class name
        //Non-Parametrised Contructor
        public ClassName Demo;

        public string Name;
        //Constrctor
        //Parametrised Constructor

        public Constrctor()
        {
            Console.WriteLine("Shruthi");
        }
        public string name;
        public Constrctor(string name, ClassName Demo)
        {
            this.name = name;
            this.Demo = Demo;
            Console.WriteLine(name);
        }
    }
}
