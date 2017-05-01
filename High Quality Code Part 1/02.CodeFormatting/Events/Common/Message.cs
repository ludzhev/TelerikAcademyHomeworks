using System.Text;

using Events.Models;

namespace Events.Common
{
    public static class Messages
    {
        private static readonly StringBuilder Output = new StringBuilder();

        public static void EventAdded()
        {
            Output.AppendLine("Event added");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendLine($"{x} events deleted");
            }
        }

        public static void NoEventsFound()
        {
            Output.AppendLine("No events found");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.AppendLine(eventToPrint.ToString());
            }
        }

        public static string ShowMessages()
        {
            return Output.ToString().Trim();
        }
    }
}
