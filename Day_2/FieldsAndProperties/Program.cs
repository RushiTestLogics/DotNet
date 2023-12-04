namespace FieldsAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o= new Class1();
            o.seti(101);
            Console.WriteLine(o.geti());

            // 
            Class2 s=new Class2();
            s.I = 10;
            Console.WriteLine(s.I);

            Class3 c1= new Class3();
            c1.S1 = "Rushikesh";
            Console.WriteLine(c1.S1);

            Console.WriteLine(c1.S4);
        }

    }

    public class Class1
    {
        private int i;
        public void seti(int Value)
        {
            if (Value <= 100)
            {
                i = Value;
            }
            else
            {
                Console.WriteLine("Invalid Number.");
            }
        }
        public int geti() 
        {
            return i;
        }
    }

    public class Class2
    {
        private int i;

        // Property of Integer
        public int I
        {
            set
            {
                if (value <= 100)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("Invalid Numbver");
                }
            }
            get
            {
                return i;
            }

        }
    }

    public class Class3
    {
        private string s1;

        // property of string.
        public string S1
        {
            set
            {
                s1 = value;
            }
            get { return s1; }
        }


        // feilds
        public string s3;

        // Automatic Property.
        public string S4 {get;set;}
    }

}