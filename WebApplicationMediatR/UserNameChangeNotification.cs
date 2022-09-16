using MediatR;

namespace WebApplicationMediatR
{
    public record UserNameChangeNotification(string OldName,string NewName) : INotification;
}
