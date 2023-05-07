
using Microsoft.Data.Sqlite;

class Project
{
    static void Main(string[] args)
    {
        //User user = new User();
        //user.Register("pesho", "333");
        //Ticket ticket = new Ticket();
        //ticket.Create(1, 2, true, DateTime.Now);
        //MainMenuController mainMenuctr = new MainMenuController();
        // mainMenuctr.Start();
        LoginMenuController login = new LoginMenuController();
        login.Start();

        // System.Console.ReadKey();

    }
}