using System;

using Events.Common;
using Events.Models;

namespace EventsApplication
{
    public class StartUp
    {
        public static void Main()
        {
            string currentCommand = Console.ReadLine();

            while (CommandHandler.ExecuteNextCommand(currentCommand))
            {
                currentCommand = Console.ReadLine();
            }

            Console.WriteLine(Messages.ShowMessages());
        }
    }
}
