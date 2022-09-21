using MediatR;
using Users.Domain.ValueObject;

namespace Users.Domain.Events
{
    public record UserAccessResultEvent(PhoneNumber PhoneNumber,UserAccessResult Result):INotification;
}
