using Users.Domain.ValueObject;

namespace Users.WebApi
{
    public record AddUserRequest(PhoneNumber PhoneNumber,string Password);
}
