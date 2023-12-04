namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Class1 o= new Class1();
            o.Display();

            o.Display("Rushikesh ");

            Console.WriteLine(o.Add(10,20));
            Console.WriteLine(o.Add(10,20,30));
            Console.WriteLine(o.Add(b:50));

            o.DoSomething();

        }
    }

    public class Class1
    {
        public void Display()
        {
            Console.WriteLine("Display ");
        }

        // Overload a function -> same function name, different parameters.
        public void Display(string s)
        {
            Console.WriteLine("Display "+s);
        }
        /*
        public int Add(int a,int b)
        {
            return a + b;
        }

        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }*/

        //public int Add(int a=0,int b=0,int c=0)
        //{
        //    return a + b + c;
        //}

        public int Add(int a=0,int b=0,int c=0)
        {
            return a + b + c;
        }

        public void DoSomething()
        {
            int i = 100;

            Console.WriteLine(i);
            void DoSomething2()
            {
                Console.WriteLine("DS2 Called");
                i++;
                Console.WriteLine(i);
            }
            DoSomething2();
            Console.WriteLine(i);
        }
    }

    public class Class2
    {

    }
}