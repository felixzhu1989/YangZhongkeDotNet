using MediatR;

namespace WebApplicationMediatR
{
    public record PostNotification(string Body) : INotification;
}
