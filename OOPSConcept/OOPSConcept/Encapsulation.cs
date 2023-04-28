using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class Encapsulation
    {  //it will hide sensitive data from the user
        //declare field or variable should be private
        //property-get: is read-only and property-set: it is used to set data

        private string name = "shruthi"; //defined field is in private

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; //name = value:it will set or assign value to the name
            }

        } 
        public int RollNo
        {
            get; set;
        }
    }
}
