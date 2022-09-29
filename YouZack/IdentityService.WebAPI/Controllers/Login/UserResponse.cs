namespace IdentityService.WebAPI.Controllers.Login
{
    public record UserResponse(Guid Id,string UserName,string PhoneNumber,DateTime CreationTime);
}
