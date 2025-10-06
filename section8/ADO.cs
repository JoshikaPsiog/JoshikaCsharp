using System;
using System.Data;
using System.Data.SqlClient;
 
class Program
{
    static string connectionString = @"Server=PSILENL060;Database=ADO;Trusted_Connection=True;";
    static void Main()
    {
        AddEmployee("Jai", "IT", 50000);
        AddEmployee("joshi", "HR", 60000);
        GetEmployees();
        UpdateEmployeeSalary(1, 55000);
        DeleteEmployee(2);
        Console.WriteLine("CRUD operations completed.");
    }
    static void AddEmployee(string name, string dept, int salary)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Employees (Name, Department, Salary) VALUES (@Name, @Dept, @Salary)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Dept", dept);
            cmd.Parameters.AddWithValue("@Salary", salary);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Added {name}");
        }
    }
    static void GetEmployees()
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM Employees";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Employees:");
            while (reader.Read())
            {
                Console.WriteLine($"{reader["Id"]} - {reader["Name"]} - {reader["Department"]} - {reader["Salary"]}");
            }
            reader.Close();
            conn.Close();
        }
    }
    static void UpdateEmployeeSalary(int id, int newSalary)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "UPDATE Employees SET Salary=@Salary WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Salary", newSalary);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Updated Employee {id} salary to {newSalary}");
        }
    }
    static void DeleteEmployee(int id)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Employees WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine($"Deleted Employee {id}");
        }
    }
}