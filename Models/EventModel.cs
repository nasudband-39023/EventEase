using System;

namespace EventEase.Models
{
    public class EventModel
    {
        /// <summary>
        /// Name of the event.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Date of the event.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Location of the event.
        /// </summary>
        public string Location { get; set; } = string.Empty;
    }
}