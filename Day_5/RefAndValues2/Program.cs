namespace RefAndValues2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int i = 100, j = 200;// for out doesn't need to assign values.
            Swap(ref i, ref j); // for ref to call the assign values
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.WriteLine();

            Init(out i, out j); // mustr be out return 
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.WriteLine();

            Print(in i);
            Print(j);// for in doesn't required [in] to write.

            Class1 o = new Class1();
            Console.WriteLine();
            o.i = 100;
            DoSOmething(o);

            Console.WriteLine(o.i);
            Console.WriteLine();

            DoSOmething1(ref o);
            Console.WriteLine(o.i);
            Console.WriteLine();

            DoSomething2(out o);    // discarded the o-> asiign to its memory.
            Console.WriteLine(o.i);
            Console.WriteLine();

            DoSomethin3(in o);
            Console.WriteLine(o.i);
            Console.WriteLine();
        }


        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        static void Init(out int a,out int b)
        {
            a = 1000;
            b = 2000;
        }

        static void Print(in int x)
        {
            //x = 100; -> get error (Can't assign the Value).
            Console.WriteLine(x);
        }

        static void DoSOmething(Class1 obj) // obj=o
        {
            obj=new Class1();   // obj=new Object and o->assign to its old 
            obj.i = 200;
        }

        static void DoSOmething1(ref Class1 obj)    //obj=o
        {
            obj = new Class1();     // obj and o points to same memory location
            obj.i = 300;        // prints -> 300
        }

        static void DoSomething2(out Class1 obj)    // obj=o
        {
            obj = new Class1(); // must be assign new object for "out" keyword.
            obj.i = 400;
        }

        static void DoSomethin3(in Class1 obj)
        {
            //obj=new Class1(); -> Can't assign new object 
            obj.i = 500;
        }
    }

    public class Class1
    {
        public int i;
    }

    
}