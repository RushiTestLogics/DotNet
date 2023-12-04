using Microsoft.Data.SqlClient;
using System;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Program.cs
﻿//using Microsoft.Data.SqlClient;
//using System.Data;

namespace Databases
{
    internal class Program
    {
        static void Main()
        {
            //Connect();
            //Insert1();

            //Employee obj = new Employee { EmpNo = 6, Name = "Ananya", Basic = 12345, DeptNo = 30 };
            Employee obj = new Employee { EmpNo = 8, Name = "D'Souza", Basic = 12345, DeptNo = 20 };
            //Insert2(obj);
            InsertWithParameters(obj);

            //SelectSingleValue();
            //MARS();
            //CallDataReaderFunction();

            //Transactions();
        }
        static void Connect()
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
            //Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Connect2()
        {
            //SqlConnection cn = new SqlConnection();
            ////cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=ActsJune23;User Id=sa;Password=sa";
            //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=ActsJune23;Integrated Security=true";
            //cn.Open();
            //Console.WriteLine("open");
            //cn.Close();
            using (SqlConnection cn = new SqlConnection())
            {
                //cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=ActsJune23;User Id=sa;Password=sa";
                cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=ActsJune23;Integrated Security=true";
                cn.Open();
                Console.WriteLine("open");
            }

        }
        static void Insert1()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(7, 'Tom',12335, 30)";

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void Insert2(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into Employees values(3, 'Shweta',12345, 10)";
                cmd.CommandText
                    = $"insert into Employees values({obj.EmpNo}, '{obj.Name}',{obj.Basic}, {obj.DeptNo})";
                //Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void InsertWithStoredProc(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void SelectSingleValue()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select Name from Employees where EmpNo = 1";
                //cmd.CommandText = "select count(*) from Employees";
                //cmd.CommandText = "select * from Employees";

                object retval = cmd.ExecuteScalar();
                Console.WriteLine(retval);
                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void DataReader1()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["EmpNo"]);

                    Employee obj = new Employee();
                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];

                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");

                }
                dr.Close();

                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        static void DataReader2()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=YcpOct23;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees;select * from Departments";
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["EmpNo"]);

                    Employee obj = new Employee();
                    obj.EmpNo = (int)dr[0];
                    obj.EmpNo = (int)dr["EmpNo"];
                    obj.EmpNo = dr.GetInt32(0);
                    obj.EmpNo = dr.GetInt32("EmpNo");

                }
                dr.NextResult();
                while (dr.Read())
                {
                    Console.WriteLine(dr[0]);
                    Console.WriteLine(dr["DeptNo"]);
                    Console.WriteLine(dr.GetInt32(0));
                    Console.WriteLine(dr.GetInt32("DeptNo"));


                }


                dr.Close();

                Console.WriteLine("success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        static void MARS()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Yash1;Integrated Security=true;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmdDepts = new SqlCommand();
            cmdDepts.Connection = cn;
            cmdDepts.CommandType = CommandType.Text;
            cmdDepts.CommandText = "Select * from Departments";

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;

            SqlDataReader drDepts = cmdDepts.ExecuteReader();
            while (drDepts.Read())
            {
                Console.WriteLine((drDepts["DeptName"]));

                cmdEmps.CommandText = "Select * from Employees where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    Console.WriteLine(("    " + drEmps["Name"]));
                }
                drEmps.Close();
            }
            drDepts.Close();
            cn.Close();

        }
        static void CallDataReaderFunction()
        {
            SqlDataReader dr = GetDataReader();
            while (dr.Read())
            {
                Console.WriteLine(dr["EmpNo"]);
            }
            dr.Close();
            //if (cn.State == ConnectionState.)
            //Console.WriteLine(cn.State);
        }
        //static SqlConnection cn = new SqlConnection();

        static SqlDataReader GetDataReader()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True";
            cn.Open();
            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "select * from Employees ";
            //SqlDataReader dr = cmdInsert.ExecuteReader();
            SqlDataReader dr = cmdInsert.ExecuteReader(CommandBehavior.CloseConnection);
            //cn.Close();
            return dr;
        }

        static void Transactions()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True";
            cn.Open();
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.Transaction = t;

            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into Employees values(10, 'Shweta', 12345, 30)";

            SqlCommand cmdInsert2 = new SqlCommand();
            cmdInsert2.Connection = cn;
            cmdInsert2.Transaction = t;

            cmdInsert2.CommandType = System.Data.CommandType.Text;
            cmdInsert2.CommandText = "insert into Employees values(20, 'Shweta', 12345, 10)";
            try
            {
                cmdInsert.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();
                t.Commit();
                Console.WriteLine("no errors- commit");
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine("Rollback");
                Console.WriteLine(ex.Message);
            }
            cn.Close();

        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}