using Microsoft.Data.SqlClient;
using System.Data;

namespace MyWebApi.Controllers
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }



        // Creating Databases with Query And Connected with Databases

        // For Getting All Employees from Database.
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> lstEmps = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employees";

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lstEmps.Add(new Employee
                    {
                        EmpNo = dr.GetInt32("EmpNo"),
                        Name = dr.GetString("Name"),
                        Basic = dr.GetDecimal("Basic"),
                        DeptNo = dr.GetInt32("DeptNo")
                    });
                }
                dr.Close();

            }

            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return lstEmps;
        }

        //Get Only One Employee From  the Database.
        public static Employee GetEmployee(int EmpNo)
        {
            Employee emp = new Employee();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";

            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Select * from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    emp.EmpNo = dr.GetInt32("EmpNo");
                    emp.Name = dr.GetString("Name");
                    emp.Basic = dr.GetDecimal("Basic");
                    emp.DeptNo = dr.GetInt32("DeptNo");

                }
                else
                    emp = null;

                dr.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }

        // Insert into Employee All Values In the Database

        public static void Insert(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";

            try
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertEmployee";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                //Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        // Updating Employee Values into Databases.
        public static void Update(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);

                cmd.ExecuteNonQuery();
                //Console.WriteLine("Success");
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        // Delete Employee Detail from Database
        public static void Delete(int EmpNo)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete from Employees where EmpNo=@EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", EmpNo);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
