using System.Security.Cryptography.X509Certificates;

namespace Employee_ToDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Employee e = new Employee(1,"Rushikesh",123456,101);
            //e.Display();

            
            Employee e1 = new Employee(2, "Shubh", 10000);
            //e1.Display();

            Employee e2 = new Employee(0, "Rushikesh");
            //e2.Display();

            Employee e3 = new Employee(empId:4);
            //e3.Display();

            //Employee e4 = new Employee();
            //e4.Display();
            
        }
    }

    public class Employee
    {
       
        public int empId;
        public int EmpId
        {
            set
            {
                if(value > 0)
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
                name = value;
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
                    Console.WriteLine("Invalid");
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

        public decimal NetSalary(decimal basic)
        {
            decimal netsalary = basic * 12;
            return netsalary;
        }

        decimal net;
        public Employee(int empId = 0, string name = "default", decimal basic = default, short deptNo = default)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
            this.net = NetSalary(basic);


            Console.WriteLine("EmpId:" + empId + "-- Name: " + name + "-- Basic:" + basic + "-- DeptNo: " + deptNo + "-- NetSalary: " + NetSalary(basic));
        }
       
        /*
        public void Display()
        {
            Console.WriteLine("EmpId:" +empId+ "-- Name: " +name+ "-- Basic:" +basic+ "-- DeptNo: " +deptNo+ "-- NetSalary: "+NetSalary(basic));
        }
       */

        public Employee(int empId=0,string name="default",decimal basic=0)
        {
            this.empId=empId;
            this.name=name;
            this.basic = basic;
            this.net=NetSalary(basic);

            Console.WriteLine("EmpId: "+ empId + "-- Name: "+ name + "-- Basic: "+ basic + "-- NetSalary: "+NetSalary(basic));
        }

        public Employee(int empId=0,string name="default")
        {
            this.empId = empId;
            this.name = name;
            this.net=NetSalary(basic);

            Console.WriteLine("EmpId: "+ empId + "-- Name: " + name + "-- NetSalary: " +NetSalary(basic));
        }

        public Employee(int empId = 0)
        {
            this.empId = empId;
            this.net= NetSalary(basic);

            Console.WriteLine("EmpId: "+ empId + "NetSalary: "+NetSalary(basic));
        }

    }
}