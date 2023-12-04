namespace Student_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int batch, student;

            Console.WriteLine("Enter Number of BAtches:-> ");
            Console.WriteLine();
            batch=Convert.ToInt32(Console.ReadLine());

            int[][] std_arr=new int[batch][];

            for(int i=0;i<std_arr.Length;i++)
            {
                Console.WriteLine($"Enter Number Of Stuents in Batch-[{i+1}] : ");
                student= Convert.ToInt32(Console.ReadLine());
                std_arr[i] = new int[student];
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Write Marks of Each Students:-> ");
            Console.WriteLine();

            for(int i = 0;i < std_arr.Length;i++)
            {
                for(int j = 0; j < std_arr[i].Length;j++)
                {
                    Console.WriteLine($"Enter Marks of Student-[{j+1}] of Batch-[{i+1}] : ");
                    std_arr[i][j]=Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Displaying All Students Marks Of Differnt Batches:");
            Console.WriteLine();
            for(int i=0;i<std_arr.Length;i++)
            {
                for(int j = 0; j < std_arr[i].Length;j++)
                {
                    Console.WriteLine($"Marks of Student-[{j+1}] of Batch-[{i+1}] is-> : [{std_arr[i][j]}]");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}