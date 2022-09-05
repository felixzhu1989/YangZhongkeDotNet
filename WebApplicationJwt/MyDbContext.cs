using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationJwt
{
    //不要忘记泛型，<MyUser,MyRole,long>
    public class MyDbContext:IdentityDbContext<MyUser,MyRole,long>
    {
        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

    }
}
