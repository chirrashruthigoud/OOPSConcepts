using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{  // typecasting is used to assign a value of one datatype to another datatype.
    //there are two types of casting implicit and explicit.
    //implicit : implicitly mean automatically convert a small type to a large type.
    //char => int => long => float => double.
    // explicit : explicit casting is should be manually.
    //reverse of the implicit convert large to small.
    //double => float => long =>int => char

    public class TypeCasting
    {
        public void method() { 
        int value = 10;
            double ValueOne = value;
            int ValueTwo = 20;
          //long add =ValueOne + ValueTwo;
            Console.WriteLine(value);
            Console.WriteLine(ValueOne);
            double ValueThree = 11.5;
            int valueFour = (int)ValueThree;
            Console.WriteLine("valueFour");
        }
    }
}
