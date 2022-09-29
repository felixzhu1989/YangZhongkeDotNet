using IdentityService.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace IdentityService.Domain
{
    public interface IIdRepository
    {
        Task<User> FindByIdAsync(Guid userId);//根据Id获取用户
        Task<User> FindByNameAsync(string userName);//根据用户名获取用户
        Task<User?> FindByPhoneNumberAsync(string phoneNum);//根据手机号获取用户
        Task<IdentityResult> CreateAsync(User user, string password);//创建用户
        Task<IdentityResult> AccessFailedAsync(User user);//记录一次登陆失败

        /// <summary>
        /// 生成重置密码的令牌
        /// </summary>
        Task<string> GenerateChangePhoneNumberTokenAsync(User user,string phoneNumber);

        /// <summary>
        /// 检查VCode，然后设置用户手机号为phoneNum
        /// </summary>
        Task<SignInResult> ChangePhoneNumberAsync(Guid userId, string phoneNumber, string token);

        /// <summary>
        /// 修改密码
        /// </summary>
        Task<IdentityResult> ChangePasswordAsync(Guid userId, string password);

        /// <summary>
        /// 获取用户角色
        /// </summary>
        Task<IList<string>> GetRolesAsync(User user);

        /// <summary>
        /// 把用户user加入角色role
        /// </summary>
        Task<IdentityResult> AddToRoleAsync(User user, string roleName);

        /// <summary>
        /// 为了登录而检查用户名、密码是否正确
        /// </summary>
        public Task<SignInResult> CheckForSignInAsync(User user, string password, bool lockoutOnFailure);

        /// <summary>
        /// 确认手机号
        /// </summary>
        public Task ConfirmPhoneNumberAsync(Guid id);

        /// <summary>
        /// 修改手机号
        /// </summary>
        public Task UpdatePhoneNumberAsync(Guid id,string phoneNumber);

        /// <summary>
        /// 删除用户
        /// </summary>
        public Task<IdentityResult> RemoveUserAsync(Guid id);

        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <returns>返回值(元组)第三个是生成的密码</returns>
        public Task<(IdentityResult, User?, string? password)> AddAdminUserAsync(string userName, string phoneNumber);


        /// <summary>
        /// 添加用户
        /// </summary>
        /// <returns>返回值(元组)第三个是生成的密码</returns>
        public Task<(IdentityResult, User?, string? password)> AddUserAsync(string userName, string phoneNumber,string roleName);

        /// <summary>
        /// 重置密码。
        /// </summary>
        /// <returns>返回值(元组)第三个是生成的密码</returns>
        public Task<(IdentityResult, User?, string? password)> ResetPasswordAsync(Guid id);
    }
}
