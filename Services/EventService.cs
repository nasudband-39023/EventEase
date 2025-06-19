using EventEaseProject.Models;

namespace EventEaseProject.Services
{
    public class EventService
    {
        private List<Event> _events;

        public EventService()
        {
            // Mock data
            _events = new List<Event>
            {
                new Event
                {
                    Id = 1,
                    Name = "Technology Conference",
                    Date = DateTime.Now.AddDays(30),
                    Location = "Seattle Convention Center",
                    Description = "Come to see our new releases."
                },
                new Event
                {
                    Id = 2,
                    Name = "Team Building Workshop",
                    Date = DateTime.Now.AddDays(15),
                    Location = "Central Park",
                    Description = "Relax and plan strategies with your mates."
                },
                new Event
                {
                    Id = 3,
                    Name = "Products Launch Event",
                    Date = DateTime.Now.AddDays(45),
                    Location = "San Francisco Auditorium",
                    Description = "Enjoy our last and updated stuff."
                }
            };
        }

        public List<Event> GetEvents()
        {
            return _events;
        }

        public Event? GetEventById(int id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }
    }
}