using MySql.Data.MySqlClient;
using System;

public class MyClass
{
    private MySqlConnection con;

    public MySqlConnection ConnectToDB(string user, string password)
    {
        try
        {
            string connectionString = $"server=Dariuss-MacBook-Air.local;user={user};persistsecurityinfo=True;database=FirstTable;password={password}";
            con = new MySqlConnection(connectionString);
            con.Open();
            Console.WriteLine("Connection Successful");
            return con;
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Connection Failed due to " + ex.Message);
            return null;
        }
    }

    public void CloseConnection()
    {
        if (con != null && con.State == System.Data.ConnectionState.Open)
        {
            con.Close();
            Console.WriteLine("Connection Closed");
        }
    }

    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        MySqlConnection connection = myClass.ConnectToDB("", "");

        // Perform database operations here

        myClass.CloseConnection();
    }
}
