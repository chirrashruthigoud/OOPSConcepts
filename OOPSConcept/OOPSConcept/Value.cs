using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
   class Value
    {
        //in value type two types are there build in type  and user-defined type.
        //built-in = int,long,float,double,byte,decimal,short,char,bool
        //user-defined type = struct and enum
        //it will store in a stack memory.

        public void ValuetypeMethod()
        {  //num_one and num_two variables are the value type
            int num_One = 12, num_Two = num_One;
            num_Two++;
                Console.WriteLine(num_One + ", " + num_Two);
        }
    }
}
