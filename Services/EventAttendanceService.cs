// EventAttendanceService.cs
public class EventAttendanceService
{
    private Dictionary<int, List<string>> eventAttendees = new();

    public void RegisterAttendance(int eventId, string userName)
    {
        if (!eventAttendees.ContainsKey(eventId))
            eventAttendees[eventId] = new List<string>();

        if (!eventAttendees[eventId].Contains(userName))
            eventAttendees[eventId].Add(userName);
    }

    public List<string> GetAttendees(int eventId)
    {
        if (eventAttendees.ContainsKey(eventId))
            return eventAttendees[eventId];
        else
            return new List<string>();
    }
}