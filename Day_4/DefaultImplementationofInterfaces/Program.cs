namespace DefaultImplementationofInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Class1 o = new Class1();

            // Try-2
            o.Insert();
            o.Update();
            o.Delete();
            //o.Select();

            IDbFunction oIdb;
            oIdb = o;
            oIdb.Select();

            Console.WriteLine();
            // Method-3
            ((IDbFunction)o).Select();
            Console.WriteLine();

            // Method-4
            (o as IDbFunction).Select();


        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

        void Select()
        {
            Console.WriteLine("Default implementaion of Select");
        }

    }

    public class Class1 : IDbFunction
    {
        public void Delete()
        {
            Console.WriteLine("This is Delete Function");
        }

        public void Display()
        {
            Console.WriteLine("Display Function.");
        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function");
        }

        //public void Select()
        //{
        //    Console.WriteLine("Class -1  implementaion of Select");
        //}

        void IDbFunction.Select()
        {
            Console.WriteLine("Class 1 Explicit implementation of select.");
        }
    }
}