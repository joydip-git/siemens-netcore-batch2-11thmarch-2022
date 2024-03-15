using System.Data.SqlClient;
using System.Data;

namespace DataAccessDemo
{
    internal class Program
    {
        static void Main()
        {
            var records = EmployeeInfos;
            records?
                .ToList()
                .ForEach(record => Console.WriteLine(record));
        }
        static IEnumerable<EmployeeInfo>? EmployeeInfos
        {
            get
            {
                //install NuGet package: System.Data.SqlClient
                string connectionString = @"Data Source=joydip-pc\sqlexpress;Initial Catalog=siemensdb;User ID=sa;Password=SqlServer@2022;Encrypt=False";
                string query = "select * from employeeinfos";
                SqlConnection? connection = null;
                SqlCommand? command = null;
                SqlDataReader? reader = null;
                List<EmployeeInfo>? list = null;
                try
                {
                    connection = new SqlConnection(connectionString);
                    //command = connection.CreateCommand();
                    //command.CommandText= query;

                    command = new SqlCommand(query, connection);
                    connection.Open();
                    //execute select query which returns multiple data, using ExecuteReader() method of SqlCommand
                    //execute select query which returns single data, using ExecuteScalar() method of SqlCommand
                    //execute other query using ExecuteNonQuery() method of SqlCommand
                    reader = command.ExecuteReader();
                    //Console.WriteLine(connection.State.ToString());
                    if (reader != null && reader.HasRows)
                    {
                        list = new List<EmployeeInfo>();
                        while (reader.Read())
                        {
                            //    Console.WriteLine(
                            //        $"Id:{reader["id"]}" +
                            //        $"\tName:{reader["empname"]}" +
                            //        $"\tSalary:{reader["empsalary"]}" +
                            //        $"\tDept:{reader["emp_dept"]}"
                            //        );

                            EmployeeInfo emp = new EmployeeInfo
                            {
                                Name = reader["empname"].ToString(),
                                Id = int.Parse(reader["id"].ToString()),
                                Salary = decimal.Parse(reader["empsalary"].ToString()),
                                Department = reader["emp_dept"].ToString()
                            };
                            list.Add(emp);
                        }
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                return list;
            }
        }
    }
}
