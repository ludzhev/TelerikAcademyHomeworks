using System;

using Events.Common;

using Wintellect.PowerCollections;

namespace Events.Models
{
    public class EventHolder
    {
        private readonly MultiDictionary<string, Event> titleCatalog = new MultiDictionary<string, Event>(true);
        private readonly OrderedBag<Event> events = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event eventToAdd = new Event(date, title, location);
            this.titleCatalog.Add(title.ToLower(), eventToAdd);
            this.events.Add(eventToAdd);
            Messages.EventAdded();
        }

        public void DeleteEvents(string eventToDeleteTitle)
        {
            string title = eventToDeleteTitle.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.titleCatalog[title])
            {
                removed++;
                this.events.Remove(eventToRemove);
            }

            this.titleCatalog.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.events.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}
