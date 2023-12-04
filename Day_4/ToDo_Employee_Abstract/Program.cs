namespace ToDo_Employee_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating object for Manager
            Manager manager = new Manager("Rushikesh",10000,11,"Mumbai");
            manager.Manager_Display();

            // calling Interface.
            manager.Insert();
            manager.Delete();
            manager.Update();
            Console.WriteLine();

            // Creating Object for GeneralManager
            GeneralManager generalManager = new GeneralManager("Rushikesh_D",101010,15,"XYZ","Diwali_Bonus");
            generalManager.GeneralManager_Display();
           
            Console.WriteLine();

            // Creating Object For CEO
            CEO cEO = new CEO("Rushi",100011,20);
            cEO.CEO_Display();
            Console.WriteLine();

            // Creating Object For Manager
            GeneralManager generalManager1 = new GeneralManager("Shubh", 105050, 30, "ABC");
            generalManager1.Manager_Display();
        }
    }

    public interface IDbFunction
    {
        void Insert();
        void Update();
        void Delete();

        void select()
        {
            Console.WriteLine("This is IDb Function.");
        }

    }


    // Class of Employee (Base Class)
    public abstract class Employee : IDbFunction
    {
        
        private static int empId = 1;
        public int EmpId
        {
            get;
        }

        private string name;
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

        // Abstracting Basic decimal.
        protected decimal basic;
        public abstract decimal Basic
        {
            get;
            set;
        }


        private short deptNo;
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

        public abstract decimal NetSalary();


        public Employee(string name = "default", decimal basic = 100, short deptNo = 10)
        {
            
            this.EmpId = empId++;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
            
        }


        public void Display()
        {
            //Console.WriteLine("EmpId: " + newempId + "-- Name: " + name + "-- Basic:" + basic + "-- DeptNo: " + deptNo + "-- NetSalary: "+NetSalary());
        }

        public void Insert()
        {
            Console.WriteLine("Employee Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee Update");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Delete");
        }
    }


    // Class Manager

    public class Manager : Employee , IDbFunction
    {

       
        private string designation;

        public string Designation
        {
            set
            {
                if(value!="")
                    designation = value;
                else
                    Console.WriteLine("Invalid Designation");
            }

            get
            {
                return designation;
            }
        }

       
        
        public override decimal Basic {
            get
            { 
                return basic;
            }
            set
            {
                if(value>1000 && value<100000)
                    basic=value;
                else
                    Console.WriteLine("Invalid Basic Value For Manager.");
            }
        }

        public override decimal NetSalary() 
        {
            decimal netsalary = Basic - Basic / 18;
            decimal netsalary1 = Decimal.Round(netsalary, 5);
            return netsalary1;
        }


        // Constructor for Manager class

        public Manager(string name = "default", decimal basic = 100, short deptNo = 10, string designation="default") : base(name, basic, deptNo)
        {
            
            this.designation = designation;

        }

        public void Manager_Display()
        {
            Console.WriteLine("Deatils Of Manager:->");
           
            Console.WriteLine("EmpId: " + EmpId + "-- Name: " + Name + "-- Basic:" + Basic + "-- DeptNo: " + DeptNo + "-- Designation: " + Designation + "-- NetSalary: " + NetSalary());
            
        }
    }

    // Class Of GeneralManager
    public class GeneralManager : Manager , IDbFunction
    {

        private string perks;

        public string Perks
        {
            set
            {
                if(value!="")
                    perks = value;
                else
                    Console.WriteLine("Invalid Perks For GeneralManager.");
            }

            get
            {
                return perks;
            }
        }

        
        public override decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value > 10000 && value < 1000000)
                    basic = value;
                else
                    Console.WriteLine("Invalid Basic Value For Manager.");
            }
        }

        public override decimal NetSalary()
        {
            decimal netsalary = Basic - Basic / 12;
            decimal netsalary1 = Decimal.Round(netsalary, 5);
            return netsalary1;
        }

        public GeneralManager(string name = "default", decimal basic = 100, short deptNo = 10, string designation = "default", string perks="default") : base(name,basic,deptNo,designation)
        {
            
            this.perks = perks;

        }

        public void GeneralManager_Display()
        {
            Console.WriteLine("Information About General Manager");
           
            Console.WriteLine("EmpId: " + EmpId + "-- Name: " + Name + "-- Basic:" + Basic + "-- DeptNo: " + DeptNo + "-- Designation: " + Designation + "-- Perks: " + Perks + "-- NetSalary: " + NetSalary());
        }
    }

    // Class of CEO
    public class CEO : Employee , IDbFunction
    {
        
        public override decimal Basic {
            get
            {
                return basic;
            }
            set
            {
                if (value > 10000 && value < 1000000)
                    basic = value;
                else
                    Console.WriteLine("Invalid Basic Value For Manager.");
            }
        }

        public sealed override decimal NetSalary()
        {
            decimal netsalary = Basic - Basic / 5;
            decimal netsalary1 = Decimal.Round(netsalary, 5);
            return netsalary1;
        }

        public CEO(string name = "default", decimal basic = 100, short deptNo = 10) : base(name,basic,deptNo)
        {
            //Console.WriteLine("CEO:");
        }

        public void CEO_Display()
        {
            Console.WriteLine("Details of CEO :->");
           
            Console.WriteLine("CEO Id: " + EmpId + "-- CEO_Name: " + Name + "-- CEO_Basic: " + Basic + "-- CEO_DeptNo: " + DeptNo + "-- NetSalary: " + NetSalary());

        }
    }
}