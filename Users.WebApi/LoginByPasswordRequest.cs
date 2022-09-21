using System.ComponentModel.DataAnnotations;
using Users.Domain.ValueObject;

namespace Users.WebApi
{
    public record LoginByPasswordRequest(PhoneNumber PhoneNumber,string Password);
}
