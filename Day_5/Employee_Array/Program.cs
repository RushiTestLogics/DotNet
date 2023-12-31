﻿using System.Security.Cryptography.X509Certificates;

namespace Employee_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number of Employees:-> ");
            num = Convert.ToInt32(Console.ReadLine());

            Employee[] employees = new Employee[num];
            
           
            for(int i= 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                //Console.WriteLine("Enter Emp Id:-> ");
                //employees[i].EmpId=Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine();

                Console.WriteLine("Enter Employee Name:-> ");
                employees[i].Name=Convert.ToString(Console.ReadLine()); 
                Console.WriteLine();

                Console.WriteLine("Enter Employee Basic:-> ");
                employees[i].Basic=Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Enter Employee DeptNo:-> ");
                employees[i].DeptNo=Convert.ToInt16((Console.ReadLine()));
            }

            Console.WriteLine();


            for(int i= 0;i < employees.Length;i++)
            {

                employees[i].Display();
            }

            Console.WriteLine();
            Console.WriteLine();

            // For Highest Salary
            Console.WriteLine("Highest Salary: -> ");
           
            Employee Emp_temp;
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[i].NetSalary() < employees[j].NetSalary())
                    {
                        Emp_temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = Emp_temp;
                    }

                }

            }
            employees[0].Display();
            Console.WriteLine();

            int empid;
            Console.Write("Enter the EMpId to search in array of Employees: ->");
            empid=Convert.ToInt32((Console.ReadLine()));

            for(int i=0;i<employees.Length;i++)
            {
                if (employees[i].EmpId==empid)
                {
                    employees[i].Display();
                }
            }
        }
    }

    public class Employee
    { 
        private static int empId;
        public int EmpId
        {

            //set
            //{
            //    if (value > 0)
            //        empId = value;
            //    else
            //        Console.WriteLine("Invalid Employee ID");
            //}
            get;
            //{
            //    return empId;
            //}
            
        }

        
        
        private string? name;
        public string? Name
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

        private decimal basic;
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
                    Console.WriteLine("Invalid Basics.");
                }

            }

            get
            {
                return basic;
            }
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

        public decimal NetSalary()
        {
            decimal netsalary = Basic - Basic / 18;
            decimal netsalary1 = Decimal.Round(netsalary, 5);
            return netsalary1;
        }


        public Employee(int empid = 1, string name = "default", decimal basic = 9999, short deptNo = 999)
        {

            this.EmpId = ++empId;
            this.Name = name;
            this.Basic = basic;
            this.DeptNo = deptNo;
        }


        public void Display()
        {
            Console.WriteLine("EmpId:" + EmpId + "-- Name: " + Name + "-- Basic:" + Basic + "-- DeptNo: " + DeptNo + "-- NetSalary: " + NetSalary());
        }

  
    }
}