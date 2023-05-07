using TicketEnums;
class LoginMenuController
{
    private UserTicketOptionsView view { get; set; }
    public LoginMenuController()
    {
        this.view = new UserTicketOptionsView();

    }

    public int Start()
    {
        UserAction action = this.view.DisplayUserMenu();

        switch (action)
        {
            case UserAction.NEW_TICKET:

                break;
            case UserAction.HISTORY:

                break;
            case UserAction.EDIT_TICKET:

                break;
            case UserAction.EXIT:
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