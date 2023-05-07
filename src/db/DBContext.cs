using Microsoft.Data.Sqlite;
class DBContext
{
    public SqliteConnection connection { get; set; }
    public DBContext()
    {
        this.connection = new SqliteConnection("Data Source=ticketstationdb.db");
        connection.Open();

    }
}
