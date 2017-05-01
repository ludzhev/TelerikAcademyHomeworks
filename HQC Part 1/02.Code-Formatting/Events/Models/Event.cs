using System;
using System.Text;

namespace Events.Models
{
    public class Event : IComparable
    {
        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; private set; }

        public string Title { get; private set; }

        public string Location { get; private set; }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;

            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Event instance cannot compare with null!");
            }

            int dateComparer = this.Date.CompareTo(other.Date);
            int titleComparer = string.Compare(this.Title, other.Title, StringComparison.Ordinal);
            int locationComparer = string.Compare(this.Location, other.Location, StringComparison.Ordinal);

            if (dateComparer != 0)
            {
                return dateComparer;
            }

            if (titleComparer != 0)
            {
                return titleComparer;
            }

            return locationComparer != 0 ? locationComparer : 0;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            builder.Append(" | " + this.Title);
            if (!string.IsNullOrEmpty(this.Location))
            {
                builder.Append(" | " + this.Location);
            }

            return builder.ToString().Trim();
        }
    }
}
