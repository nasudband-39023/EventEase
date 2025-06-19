using EventEaseProject.Models;

namespace EventEaseProject.Services
{
    public static class SessionState
    {
        private static Dictionary<int, List<RegistrationModel>> _eventRegistrations = new();
        
        public static void RegisterForEvent(int eventId, RegistrationModel registration)
        {
            if (!_eventRegistrations.ContainsKey(eventId))
            {
                _eventRegistrations[eventId] = new List<RegistrationModel>();
            }
            
            _eventRegistrations[eventId].Add(registration);
        }
        
        public static List<RegistrationModel> GetRegistrationsForEvent(int eventId)
        {
            if (_eventRegistrations.ContainsKey(eventId))
            {
                return _eventRegistrations[eventId];
            }
            
            return new List<RegistrationModel>();
        }
        
        public static int GetRegistrationCountForEvent(int eventId)
        {
            if (_eventRegistrations.ContainsKey(eventId))
            {
                return _eventRegistrations[eventId].Count;
            }
            
            return 0;
        }
    }
}