using MediatR;

namespace WebApplicationMediatR
{
    public record NewUserNotification(string Name,DateTime CreateTime) : INotification;

}
