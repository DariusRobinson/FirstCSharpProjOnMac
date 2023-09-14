using MySql.Data.MySqlClient;



public class MyClass
{
    static MySqlConnection con;

    public void ConnectToDB(string user, string password)
    {
        con = new MySqlConnection();

        try
        {
            con.ConnectionString = "server = localhost; User Id = " + user + ";" + "Persist Security Info = True; datatbase = hello; Password = " + password + ";";
        }
        catch (Exception ex)
        {
            Console.WriteLine("Not succesful! due to ")
        }
    }
}



