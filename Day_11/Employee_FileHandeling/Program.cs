namespace Employee_FileHandeling
{
    internal class Program
    {
        static List<Employee> employees = new List<Employee>();
        static void AddEmps()
        {
            employees.Add(new Employee(1, "Rushikesh", 10000, 10));
            employees.Add(new Employee(2, "James", 20000, 20));
            employees.Add(new Employee(3, "Jerry", 30000, 30));
            employees.Add(new Employee(4, "Tom", 250000, 40));
            employees.Add(new Employee(5, "Shubh", 35000, 50));
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //AddEmps();
            //WriteToFile(employees);
            ReadFromFile();

            RecreateObj();

            Display();



        
        }


        // Create or open a file in text format

        private static void WriteToFile(List<Employee> employees)
        {

            StreamWriter writer = File.AppendText("C:\\Users\\HP\\Documents\\DotNet\\Day_11\\Employees.txt");

            foreach(Employee emp in employees)
            {
                writer.WriteLine(emp.EmpId);
                writer.WriteLine(emp.Name);
                writer.WriteLine(emp.Basic);
                writer.WriteLine(emp.DeptNo);
                writer.WriteLine();
            }

            //Console.WriteLine("File Created Successfully.");

            writer.Close();
        }

        // Read from file.
        private static void ReadFromFile()
        {
            string s;
            StreamReader reader = File.OpenText("C:\\Users\\HP\\Documents\\DotNet\\Day_11\\Employees.txt");

            while((s=reader.ReadLine())!=null)
            {
                Console.WriteLine(s);
            }

            reader.Close();
        }

        // Recreating an object foe employeeFile

        private static void RecreateObj()
        {
            StreamReader reader = File.OpenText("C:\\Users\\HP\\Documents\\DotNet\\Day_11\\Employees.txt");

            int empNo = 0;
            string name = "";
            decimal basic = 0;
            short deptNo = 0;

            while(true)
            {
                string s=reader.ReadLine();
                if (s != null)
                {
                    empNo = Convert.ToInt32(s);

                }
                else break;
                

                s=reader.ReadLine();
                if(s != null)
                {
                    name = Convert.ToString(s);
                }
                

                s=reader.ReadLine();
                if(s != null)
                {
                    basic = Convert.ToDecimal(s);
                }
                

                s= reader.ReadLine();
                if (s != null)
                {
                    deptNo = Convert.ToInt16(s);
                }
                
                Employee e= new Employee(empNo, name, basic, deptNo);
                employees.Add(e);

            }

            reader.Close();
        }

        public static void Display()
        {
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.EmpId+" , "+emp.Name+" , "+emp.Basic+" ," +emp.DeptNo+" , ");
                Console.WriteLine();
            }
        }
    }


    public class Employee
    {

        public int empId;
        public int EmpId
        {
            set
            {
                if (value > 0)
                {
                    empId = value;
                }

            }

            get
            {
                return empId;
            }
        }

        public string name;
        public string Name
        {
            set
            {
                if(value!="")
                    name = value;
                else
                    Console.WriteLine("Invalid Name.");
            }

            get
            {
                return name;
            }
        }

        public decimal basic;
        public decimal Basic
        {
            set
            {
                if (value > 0 && value < 100000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Basic.");
                }

            }

            get
            {
                return basic;
            }
        }

        public short deptNo;
        public short DeptNo
        {
            set
            {
                if (value > 0)

                {
                    deptNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Dept Number");
                }
            }

            get
            {
                return deptNo;
            }
        }

        public decimal NetSalary()
        {
            decimal netSal = Basic - Basic / 18;
            decimal net = Decimal.Round(netSal, 5);
            return net;
        }
        public Employee(int empId = 0, string name = "default", decimal basic = default, short deptNo = default)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }

        
        /*
        public void Display()
        {
            Console.WriteLine("EmpId:" +EmpId+ "-- Name: " +Name+ "-- Basic:" +Basic+ "-- DeptNo: " +DeptNo+ "-- NetSalary: "+NetSalary());
        }*/
    }

}