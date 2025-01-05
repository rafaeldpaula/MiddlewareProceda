using MiddlewareProceda.Domain.Entities;
using MiddlewareProceda.Domain.Enums;

namespace MiddlewareProceda.Domain.Specifications;

public class ActiveUserSpecification : ISpecification<User>
{
    public bool IsSatisfiedBy(User user)
    {
        return user.Status == UserStatus.Active;
    }
}
