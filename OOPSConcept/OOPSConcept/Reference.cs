using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    class Reference
    {
        public void ReferenceMethod(ref int num)
        {
            num = num * num;
            Console.WriteLine(num);
        }
    }
}
