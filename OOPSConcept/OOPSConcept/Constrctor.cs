using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcept
{
    public class TV
    {
         string name;
         int cost;

        // Parameterized constructor
        public TV(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        // Non-parameterized constructor
        public TV()
        {
            this.name = "LG";
            this.cost = 52000;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Tv Name: " + name);
            Console.WriteLine("cost: " + cost);
        }
    }
}
