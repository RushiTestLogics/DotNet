using Microsoft.Data.SqlClient;
using System.Data;

namespace DataSetExample
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World.");
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from Employees";
                //cmd.CommandText = "select count(*) from Employees";
                //cmd.CommandText = "select * from Employees";

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds, "Emps");

                // additing departments column
                cmd.CommandText = "select * from Departments";
                da.Fill(ds, "Deps");

                //primary key constrints
                DataColumn[] arrCols = new DataColumn[1];
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
                ds.Tables["Emps"].PrimaryKey = arrCols;


                // foreign key constraints
                ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"], ds.Tables["Emps"].Columns["DeptNo"]);


                // 
                dataGridView1.DataSource = ds.Tables["Emps"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = System.Data.CommandType.Text;

                // For Updating Values In Em[ployees.
                cmdUpdate.CommandText = "update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";
                //cmd.CommandText = "select count(*) from Employees";
                //cmd.CommandText = "select * from Employees";

                // create sqlParameter

                //SqlParameter p = new SqlParameter();
                //p.ParameterName= "@Name";
                //p.SourceColumn = "Name";
                //p.SourceVersion = DataRowVersion.Current;
                //cmdUpdate.Parameters.Add(p);
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

                // For Inserting Values in Employees 
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;

                cmdInsert.CommandText = "insert into Employees values (@EmpNo,@Name,@Basic,@DeptNo)";

                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                // For Delete values in Employee
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = cn;
                cmdDelete.CommandType = System.Data.CommandType.Text;

                cmdDelete.CommandText = "delete from Employees where EmpNo=@EmpNo";

                cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
                //cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                //cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                //cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });


                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = cmdUpdate;
                da.InsertCommand = cmdInsert;
                da.DeleteCommand = cmdDelete;


                da.Update(ds, "Emps");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = YcpOct23; Integrated Security = True";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values EmpNo=@EmpNo,Name=@Name,Basic=@Basic,DeptNo=@DeptNo";
                //cmd.CommandText = "select count(*) from Employees";
                //cmd.CommandText = "select * from Employees";
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });


                SqlDataAdapter da = new SqlDataAdapter();
                //da.UpdateCommand = cmdUpdate;
                da.InsertCommand = cmdInsert;

                da.Update(ds, "Emps");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            */
        }
    }
}