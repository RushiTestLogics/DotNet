namespace ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //int i = 10;
            int? i = 20;
            int j;

            //if(i !=null)
            //    j =(int) i;
            //else
            //{
            //    j = 0;
            //}

            //if(i.HasValue)
            //    j = i.Value;
            //else
            //    j = 0;

            //j = i.GetValueOrDefault();

            //j=i.GetValueOrDefault(20);

            j = i ?? 0;

            Console.WriteLine(j);
        }
    }
}