using System.Security.Cryptography.X509Certificates;

namespace OOPSConcept
{
    public class Program
    {
        const int value = 10;//it is best way to create a enum
        public static void Main()
        {
            /* Calculator calc = new Calculator();
             calc.SayHello();
             int result = calc.AddNumbers(10, 20);
             Console.WriteLine("Result: " + result);*/

            // interface
            /* Calculator obj = new Calculator();
             obj.WithoutImplementionmethod();*/


            //enum

             Console.WriteLine(ENUMDatatype.shruthi);
             int count = (int)ENUMDatatype.sunny;
             Console.WriteLine(count);

            //inheritance 

            /* InheritanceParent parent = new InheritanceParent();
              parent.name = "shruthi";
              parent.Testname();
              parent.Class();*/

            //abstract
            //Program program = new Program();
            //program.nonabstractmethod();
            //program.abstractmetod();
             //}
        //this is abstract method
        //it will override keyword the base class method in the dervied class
        /*public override void abstractmetod()
        {
             Console.WriteLine("this is overrided/implemented abstract method");
        }
       /*TypeCasting obj = new TypeCasting();
         obj.method();*/

        /*   Value obj = new Value();
             obj.ValuetypeMethod();*/

        /* Reference obj= new Reference();
            int value = 5;
            Console.WriteLine(value);
            obj.ReferenceMethod(ref value);
            Console.WriteLine(value);*/

        /*OverLoading obj = new OverLoading();
          obj.MethodOverloading();
          obj.MethodOverloading(4, "shruthi");
          obj.MethodOverloading(4);*/

        Encapsulation obj =new Encapsulation();
              Console.WriteLine(obj.Name);
            obj.Name = "shruthi";
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.RollNo = 3456);
        }
    }
}