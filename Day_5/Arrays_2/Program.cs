namespace Arrays_2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] arr = { 1, 2, 3, 4, 5, 6, 8 };
            int[] arr2 = new int[3] { 10, 20, 30 };
            int[] arr3 = { 55, 11, 33, 44, 99 };
            int pos = Array.IndexOf(arr, 6);
            Console.WriteLine(pos);
            Console.WriteLine();

            pos = Array.LastIndexOf(arr, 5);
            Console.WriteLine(pos);
            Console.WriteLine();

            pos=Array.BinarySearch(arr, 9);
            Console.WriteLine(pos);
            Console.WriteLine();

            //Array.Clear(arr);

            //Array.Copy(arr3, arr2, arr3.Length);



        }

        // 2-D array
        static void Main2()
        {
            int[,] arr = new int[4, 3];


            Console.WriteLine(arr.Rank);
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            Console.WriteLine(arr.GetUpperBound(0));
            Console.WriteLine(arr.GetUpperBound(1));

            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.WriteLine($"Enter Value for Arr[{i},{j}] : ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }


            // Printing the Array.

            for(int i=0;i< arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.WriteLine($"Array [{i},{j}] is {arr[i,j]}");

                }
                Console.WriteLine();

            }

        }

        // Jagged Array
        static void Main()
        {
            int[][] arr = new int[4][];


            arr[0] = new int[4]; 
            arr[1] = new int[3];
            arr[2] = new int[2];
            arr[3] = new int[2];


            for(int i=0;i<arr.Length;i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.WriteLine("Enter value for subscript [{0}] [{1}] : ",i,j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for(int i=0;i<arr.Length;i++)
            {
                for(int j = 0; j < arr[i].Length;j++)
                {
                    Console.WriteLine("Value For Subscript is {0},{1} is {2}  ", i, j, arr[i][j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
    }
}