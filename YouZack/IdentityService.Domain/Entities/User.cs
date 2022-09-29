using Microsoft.AspNetCore.Identity;
using Zack.DomainCommons.Models;

namespace IdentityService.Domain.Entities
{
    //NuGet安装：Install-Package Zack.DomainCommons
    public class User : IdentityUser<Guid>, IHasCreationTime, IHasDeletionTime, ISoftDelete
    {
        public DateTime CreationTime { get; init; }//创建时间
        public DateTime? DeletionTime { get; private set; }//删除时间
        public bool IsDeleted { get; private set; }//软删除

        public User(string userName) : base(userName)
        {
            Id=Guid.NewGuid();
            CreationTime=DateTime.Now;
        }
        public void SoftDelete()
        {
            IsDeleted = true;
            DeletionTime=DateTime.Now;
        }
    }
}
