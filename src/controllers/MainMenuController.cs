using TicketEnums;
class MainMenuController
{
    private UserView view { get; set; }
    public MainMenuController()
    {
        this.view = new UserView();

    }

    public int Start()
    {
        StartMenuAction action = this.view.DisplayStartMenu();

        switch (action)
        {
            case StartMenuAction.LOGIN:

                break;
            case StartMenuAction.REGISTER:

                break;
            case StartMenuAction.EXIT:
                System.Console.WriteLine("Program is closing...");
                System.Console.WriteLine("3");
                Thread.Sleep(1000);
                System.Console.WriteLine("2");
                Thread.Sleep(1000);
                System.Console.WriteLine("1");
                Thread.Sleep(1000);
                System.Environment.Exit(0);
                break;
            default:
                break;
        }


        return 0;
    }
}