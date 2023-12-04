using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int[] arr= new int[5];

            for(int i=0; i<arr.Length; i++)
            {
                //arr[i] = int.Parse(Console.ReadLine());

                // string concatenation.
                //Console.Write("Enter value for arr["+ i.ToString() +"]: ");


                //placeholder.
                //Console.Write("Enter value for arr[{0}]",i);


                //string interpolation
                //begin with a $" -> no space in between $ and "
                //use {variable} inside.
                Console.Write($"Enter Value for arr[{i}]");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int i in arr)       // Read Only LOOP.
            {
                Console.WriteLine(i);
            }
        }

        static void Main()
        {
            int per;
            int[,] arr = new int[3,5];

            for(int i=1; i<=arr.GetLength(0); i++)
            {
                for(int j=1; j<=arr.GetLength(1);j++)
                {
                    Console.Write($"Enter Value for Student Batch No->: [{i}] -> And Student:[{j}]  Marks");
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();

            }

            
            for (int i = 1; i <= arr.GetLength(0); i++)
            {
                for (int j = 1; j <= arr.GetLength(1); j++)
                {
                    Console.Write($"Student Percentage of BatchNo: [{i}] Student No: [{j}]:-> Marks:-> {arr[i,j]} :  ");
                    Console.WriteLine();
                }
                Console.WriteLine();

            }


        }
    }


}