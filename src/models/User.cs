using Microsoft.Data.Sqlite;
class UserModel
{
    public DBContext ctx { get; set; }
    public UserModel()
    {
        this.ctx = new DBContext();
    }
    public void Register(string username, string password)
    {
        SqliteCommand command = this.ctx.connection.CreateCommand();
        command.CommandText =
        @"

            INSERT INTO user (username, password) VALUES ($username, $password);
        ";
        command.Parameters.AddWithValue("$username", username);
        command.Parameters.AddWithValue("$password", password);
        try
        {
            command.ExecuteNonQuery();
        }
        catch (SqliteException e)
        {
            if (e.SqliteErrorCode == 19)
            {
                Console.WriteLine("User with that username already exists");
            }
        }
    }
}