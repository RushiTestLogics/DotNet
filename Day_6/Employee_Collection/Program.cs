namespace Employee_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            List<Employee> list = new List<Employee>();

            Employee obj = new Employee { EmpId = 1 ,Name="Rushi",Basic=10000};

            list.Add(obj);

            list.Add(new Employee{ EmpId=2,Name="Shubh",Basic=20000});
            list.Add(new Employee { EmpId = 3, Name = "Tom", Basic = 30000 });


            foreach(Employee emp in  list)
            {
                Console.WriteLine("EmpId: "+emp.EmpId+"  Name: "+emp.Name+"  Basic: "+emp.Basic);
            }


        }
    }

    public class Employee
    {
        private static int empId;
        public int EmpId
        {
            get;
            set;
            
        }

        private string? name;
        public string? Name
        {
            get;
            set;
        }

        private decimal basic;
        public decimal Basic
        {
            get;
            set;
        }

       
    }
}