using System;
using TicketEnums;

class UserView
{

    public StartMenuAction DisplayStartMenu()
    {
        Console.WriteLine("Welcome, to my ticket station.\n");
        while (true)
        {
            Console.WriteLine("Login=(1)");
            Console.WriteLine("Register=(2)");
            Console.WriteLine("Exit=(3)\n");
            ConsoleKeyInfo holder = Console.ReadKey(intercept: true);
            char h = ((char)holder.Key);


            switch (h)
            {
                case '1':

                    return StartMenuAction.LOGIN;
                case '2':

                    return StartMenuAction.REGISTER;
                case '3':

                    return StartMenuAction.EXIT;
                default:
                    System.Console.WriteLine("Please, choose valid option.");
                    break;

            }
        }
    }
}