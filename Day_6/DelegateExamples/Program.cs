namespace DelegateExamples
{
    internal class Program
    {
        public delegate void Del1();    // create a delegate class for void Display(). 
        public delegate int Del2(int a,int b);  // delegate class for int with 2 parameters int (int ,int ) 
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Del1 oDel = new Del1(Display);
            Del1? oDel = Display;
            oDel();     // oDel is Pointing to Display Function , so it return Display.

            //oDel = show;
            //oDel();

            Console.WriteLine();

            oDel += show;
            oDel();
            Console.WriteLine();

            oDel += Display;
            oDel();

            Console.WriteLine();
            oDel -= Display;
            oDel!();

            Console.WriteLine();
            oDel -= show;
           // oDel -= Display;
            oDel!();

            Del2 oDel2;

            oDel2 = Add;
            //oDel2(5, 10);
            Console.WriteLine("Addition: "+oDel2(5,10));
            Console.WriteLine();

            oDel2 += subtract;      // override the add function
            Console.WriteLine("Difference: "+oDel2(10,5));  // only display subtraction value.

        }


        static void Display()
        {
            Console.WriteLine("Display.");
        }

        static void show()
        {
            Console.WriteLine("SHOW.");
        }

        static int Add(int a,int b)
        {
            return a + b;
        }
        static int subtract(int a,int b)
        {
            return a - b;
        }
    }
}
