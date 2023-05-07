using System;
using TicketEnums;

class UserTicketOptionsView
{

    public UserAction DisplayUserMenu()
    {
        // Console.WriteLine("Welcome, to my ticket station.\n");
        while (true)
        {
            Console.WriteLine("Buy new ticket=(1)");
            Console.WriteLine("View ticket History=(2)");
            Console.WriteLine("Edit existing ticket =(3)");
            Console.WriteLine("Exit=(4)\n");
            ConsoleKeyInfo holder = Console.ReadKey(intercept: true);
            char h = ((char)holder.Key);


            switch (h)
            {
                case '1':

                    return UserAction.NEW_TICKET;
                case '2':

                    return UserAction.HISTORY;
                case '3':

                    return UserAction.EDIT_TICKET;
                case '4':

                    return UserAction.EXIT;
                default:
                    System.Console.WriteLine("Please, choose valid option.");
                    break;

            }
        }
    }
}