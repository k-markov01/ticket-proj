using Microsoft.Data.Sqlite;
class Ticket
{
    public DBContext ctx { get; set; }
    public Ticket()
    {
        this.ctx = new DBContext();
    }
    public void Create(int user_id, int destination_station_id, bool two_way, DateTime departure_time)
    {
        SqliteCommand command = this.ctx.connection.CreateCommand();
        command.CommandText =
        @"
            INSERT INTO ticket (user_id, destination_station_id,two_way,departure_time) VALUES($user_id, $destination_station_id, $two_way, $departure_time);
        
        ";
        command.Parameters.AddWithValue("$user_id", user_id);
        command.Parameters.AddWithValue("$destination_station_id", destination_station_id);
        command.Parameters.AddWithValue("$two_way", two_way);
        command.Parameters.AddWithValue("$departure_time", departure_time);
        command.ExecuteNonQuery();


    }
}