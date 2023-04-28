namespace OOPSConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Object();
            obj.Name="shruthi";
            obj.Age = 25;
            obj.SayHello();
            
            Object obj_two = new Object();
            obj_two.Name = "sunny";
            obj_two.Age = 56 ;
            obj_two.SayHello();
            Console.ReadKey();
        }
    }
}
