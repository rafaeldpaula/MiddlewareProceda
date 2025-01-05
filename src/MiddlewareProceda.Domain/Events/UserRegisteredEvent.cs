using MiddlewareProceda.Domain.Entities;

namespace MiddlewareProceda.Domain.Events
{
    public class UserRegisteredEvent
    {
        public User User { get; }

        public UserRegisteredEvent(User user)
        {
            User = user;
        }
    }
}
