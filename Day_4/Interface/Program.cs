using System.Xml.Serialization;

namespace Interface
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o = new Class1();
            o.Display();

            //Method-1
            o.Insert();
            o.Delete();
            o.Update();

            //Method-2
            IDbFunction Idb;
            Idb = o;
            Idb.Insert();
            Idb.Update();
            Idb.Delete();

            //Method-3
            ((IDbFunction)o).Insert();
            ((IDbFunction)o).Update();
            ((IDbFunction)o).Delete();  

            //Method-4
            (o as IDbFunction).Insert();
            (o as IDbFunction).Update();
            (o as IDbFunction).Delete();    
        }
    }

    


    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

    }

    public class Class1 : IDbFunction
    {
        
        public void Delete()
        {
            Console.WriteLine("This is Delete Function");
        }

        public void Display()
        {

        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function");
        }
    }
}



namespace Interface1
{
    internal class Program
    {
        static void Main2(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o = new Class1();
            o.Display();

            //Method-1
            o.Insert();
            o.Delete();
            o.Update();

            //Method-2
            IDbFunction Idb;
            Idb = o;
            Idb.Insert();
            Idb.Update();
            Idb.Delete();

            IFileFunction IFF;
            IFF = o;
            IFF.Open();
            IFF.Close();
            IFF.Delete();

            //Method-3
            ((IDbFunction)o).Insert();
            ((IDbFunction)o).Update();
            ((IDbFunction)o).Delete();

            ((IFileFunction)o).Open();
            ((IFileFunction)o).Close();
            ((IFileFunction)o).Delete();

            //Method-4
            (o as IDbFunction).Insert();
            (o as IDbFunction).Update();
            (o as IDbFunction).Delete();

            (o as IFileFunction).Open();
            (o as IFileFunction).Close();
            (o as IFileFunction).Delete();
        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

    }

    public interface IFileFunction
    {
        void Open();
        void Close();
        void Delete();

    }

    public class Class1 : IDbFunction,IFileFunction
    {
        public void Delete()
        {
            Console.WriteLine("This is Delete Function");
        }

        public void Display()
        {

        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function");
        }

        void IFileFunction.Close()
        {
            Console.WriteLine("This is IFile Function Close FIle");
        }

        void IFileFunction.Delete()
        {
            Console.WriteLine("This is IFile Function Delete FIle");
        }

        void IFileFunction.Open()
        {
            Console.WriteLine("This is IFile Function Open FIle");
        }
    }
}


namespace Interface2
{
    internal class Program
    {
        static void Main3(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o = new Class1();
            o.Display();

            //Method-1
            o.Insert();
           // o.Delete();
            o.Update();
            o.Open();
            o.Close();
            

            //Method-2
            IDbFunction Idb;
            Idb = o;
            Idb.Insert();
            Idb.Update();
            Idb.Delete();

            IFileFunction IFF;
            IFF = o;
            IFF.Open();
            IFF.Close();
            IFF.Delete();

            //Method-3
            ((IDbFunction)o).Insert();
            ((IDbFunction)o).Update();
            ((IDbFunction)o).Delete();

            ((IFileFunction)o).Open();
            ((IFileFunction)o).Close();
            ((IFileFunction)o).Delete();

            //Method-4
            (o as IDbFunction).Insert();
            (o as IDbFunction).Update();
            (o as IDbFunction).Delete();

            (o as IFileFunction).Open();
            (o as IFileFunction).Close();
            (o as IFileFunction).Delete();
        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

    }

    public interface IFileFunction
    {
        void Open();
        void Close();
        void Delete();

    }

    public class Class1 : IDbFunction, IFileFunction
    {
        void IDbFunction.Delete()
        {
            Console.WriteLine("This is Delete Function");
        }

        public void Display()
        {

        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function");
        }

        public void Close()
        {
            Console.WriteLine("This is IFile Function Close FIle");
        }

       void IFileFunction.Delete()
        {
            Console.WriteLine("This is IFile Function Delete FIle");
        }

        public void Open()
        {
            Console.WriteLine("This is IFile Function Open FIle");
        }
    }
}


namespace Interface3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class1 o = new Class1();
            o.Display();

            //Method-1
            o.Insert();
            o.Delete();
            o.Update();

            Class2 o2 = new Class2();
            o2.Show();
            o2.Insert();
            o2.Update();
            o2.Delete();



            //Method-2
            IDbFunction Idb;
            Idb = o;
            Idb.Insert();
            Idb.Update();
            Idb.Delete();

            Idb = o2;
            o2.Insert();
            o2.Update();
            o2.Delete();

            //Method-3
            ((IDbFunction)o).Insert();
            ((IDbFunction)o).Update();
            ((IDbFunction)o).Delete();

            ((IDbFunction)o2).Insert();
            ((IDbFunction)o2).Update();
            ((IDbFunction)o2).Delete();

            //Method-4
            (o as IDbFunction).Insert();
            (o as IDbFunction).Update();
            (o as IDbFunction).Delete();

            (o2 as IDbFunction).Insert();
            (o as IDbFunction).Update();
            (o as IDbFunction).Delete();
        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

    }

    public class Class1 : IDbFunction
    {
        public void Delete()
        {
            Console.WriteLine("This is Delete Function");
        }

        public void Display()
        {

        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function");
        }
    }

    // Class-2

    public class Class2 : IDbFunction
    {
        public void Delete()
        {
            Console.WriteLine("This is Delete Function for Class-2");
        }

        public void Show()
        {
            Console.WriteLine("This is Shoe Function.");
        }

        public void Insert()
        {
            Console.WriteLine("This is Insert Function for Class-2");
        }

        public void Update()
        {
            Console.WriteLine("This is UpDate Function for Class-2");
        }
    }
}