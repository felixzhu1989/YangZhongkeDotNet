using Microsoft.AspNetCore.Identity;

namespace WebApplicationIdentity
{
    public class MyUser:IdentityUser<long>
    {
        public string? WeChartAccount { get; set; }
    }
}
