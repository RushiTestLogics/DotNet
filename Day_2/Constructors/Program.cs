namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o=new Class1();
            Console.WriteLine(o.i);

            Class1 o1=new Class1(100);
            Console.WriteLine(o1.i);
        }
    }

    public class Class1
    {
        public int i;
        public Class1()
        {
            Console.WriteLine("Thgis is No Parameterised Constructor Called.");
            i = 10;
        }

        public Class1(int i)
        {
            Console.WriteLine("This is Parametrised Constructor Called.");
            this.i = i; 
        }
    }
}