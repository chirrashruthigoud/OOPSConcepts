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

            //interface
            /*Calculator obj = new Calculator();
            obj.WithoutImplementionmethod();*/


            //enum

            /* Console.WriteLine(ENUMDatatype.shruthi);
             int count = (int)ENUMDatatype.sunny;
             Console.WriteLine(count);*/


            //inheritance
           Inheritance parent = new Inheritance();
            parent.name = "shruthi";
            parent.Testname();
            parent.Class();
        }
    }
}