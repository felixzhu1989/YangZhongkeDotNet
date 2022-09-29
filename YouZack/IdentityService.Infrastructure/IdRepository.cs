using System.Text;
using IdentityService.Domain;
using IdentityService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace IdentityService.Infrastructure
{
    public class IdRepository : IIdRepository
    {
        private readonly IdUserManager _userManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly ILogger<IdRepository> _logger;
        public IdRepository(IdUserManager userManager, RoleManager<Role> roleManager, ILogger<IdRepository> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        public Task<User> FindByIdAsync(Guid userId)
        {
            return _userManager.FindByIdAsync(userId.ToString());
        }

        public Task<User> FindByNameAsync(string userName)
        {
            return _userManager.FindByNameAsync(userName);
        }

        public Task<User?> FindByPhoneNumberAsync(string phoneNum)
        {
            return _userManager.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNum);
        }

        public Task<IdentityResult> CreateAsync(User user, string password)
        {
            return _userManager.CreateAsync(user, password);
        }

        public Task<IdentityResult> AccessFailedAsync(User user)
        {
            return _userManager.AccessFailedAsync(user);
        }

        public Task<string> GenerateChangePhoneNumberTokenAsync(User user, string phoneNumber)
        {
            return _userManager.GenerateChangePhoneNumberTokenAsync(user, phoneNumber);
        }

        public async Task<SignInResult> ChangePhoneNumberAsync(Guid userId, string phoneNumber, string token)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user==null) throw new ArgumentNullException($"{nameof(user)},{userId}用户不存在");
            var changeResult = await _userManager.ChangePhoneNumberAsync(user, phoneNumber, token);
            if (!changeResult.Succeeded)
            {
                await _userManager.AccessFailedAsync(user);
                string errMsg = changeResult.Errors.SumErrors();
                _logger.LogWarning($"{phoneNumber}，ChangePhoneNumberAsync失败，错误信息：{errMsg}");
                return SignInResult.Failed;
            }
            await ConfirmPhoneNumberAsync(user.Id);//确认手机号
            return SignInResult.Success;
        }

        public async Task<IdentityResult> ChangePasswordAsync(Guid userId, string password)
        {
            if (password.Length < 3)
            {
                IdentityError err = new IdentityError
                {
                    Code = "Password Invalid",
                    Description = "密码长度不能小于3"
                };
                return IdentityResult.Failed(err);
            }
            var user = await _userManager.FindByIdAsync(userId.ToString());
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetPwdResult = await _userManager.ResetPasswordAsync(user, token, password);
            return resetPwdResult;
        }

        public Task<IList<string>> GetRolesAsync(User user)
        {
            return _userManager.GetRolesAsync(user);
        }

        public async Task<IdentityResult> AddToRoleAsync(User user, string roleName)
        {
            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                Role role = new Role { Name = roleName };
                var result = await _roleManager.CreateAsync(role);
                if (result.Succeeded == false) return result;
            }
            return await _userManager.AddToRoleAsync(user, roleName);
        }

        /// <summary>
        /// 尝试登录，如果lockoutOnFailure为true，则登录失败还会自动进行lockout计数
        /// </summary>
        public async Task<SignInResult> CheckForSignInAsync(User user, string password, bool lockoutOnFailure)
        {
            if (await _userManager.IsLockedOutAsync(user))
            {
                return SignInResult.LockedOut;
            }
            var success = await _userManager.CheckPasswordAsync(user, password);
            if (success) return SignInResult.Success;
            if (lockoutOnFailure)
            {
                var result = await AccessFailedAsync(user);
                if (!result.Succeeded) throw new ApplicationException("AccessFailedAsync return failed");
            }
            return SignInResult.Failed;
        }

        public async Task ConfirmPhoneNumberAsync(Guid id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) throw new ArgumentException($"找不到用户，id={id}", nameof(id));
            user.PhoneNumberConfirmed = true;
            await _userManager.UpdateAsync(user);
        }

        public async Task UpdatePhoneNumberAsync(Guid id, string phoneNumber)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) throw new ArgumentException($"找不到用户，id={id}", nameof(id));
            user.PhoneNumber=phoneNumber;
            await _userManager.UpdateAsync(user);
        }

        /// <summary>
        /// 软删除
        /// </summary>
        public async Task<IdentityResult> RemoveUserAsync(Guid id)
        {
            var user = await FindByIdAsync(id);
            var userLoginStore = _userManager.UserLoginStore;
            var noneCT = default(CancellationToken);
            //一定要删除aspnetuserlogins表中的数据，否则再次用这个外部登录登录的话
            //就会报错：The instance of entity type 'IdentityUserLogin<Guid>' cannot be tracked because another instance with the same key value for {'LoginProvider', 'ProviderKey'} is already being tracked.
            //而且要先删除aspnetuserlogins数据，再软删除User
            var logins = await userLoginStore.GetLoginsAsync(user, noneCT);
            foreach (var login in logins)
            {
                await userLoginStore.RemoveLoginAsync(user, login.LoginProvider, login.ProviderKey, noneCT);
            }
            user.SoftDelete();
            var result = await _userManager.UpdateAsync(user);
            return result;
        }

        private static IdentityResult ErrorResult(string msg)
        {
            IdentityError idError = new IdentityError { Description = msg };
            return IdentityResult.Failed(idError);
        }

        private string GeneratePassword()
        {
            var options = _userManager.Options.Password;
            int length = options.RequiredLength;
            bool nonAlphanumeric = options.RequireNonAlphanumeric;
            bool digit = options.RequireDigit;
            bool lowercase = options.RequireLowercase;
            bool uppercase = options.RequireUppercase;
            StringBuilder password = new StringBuilder();
            Random random = new Random();
            while (password.Length<length)
            {
                char c = (char)random.Next(32, 126);
                password.Append(c);
                if (char.IsDigit(c)) digit = false;
                else if (char.IsLower(c)) lowercase = false;
                else if (char.IsUpper(c)) uppercase = false;
                nonAlphanumeric = false;
            }
            if (nonAlphanumeric)
                password.Append((char)random.Next(33, 48));
            if (digit)
                password.Append((char)random.Next(48, 58));
            if (lowercase)
                password.Append((char)random.Next(97, 123));
            if (uppercase)
                password.Append((char)random.Next(65, 91));
            return password.ToString();
        }

        /// <summary>
        /// 创建用户，并添加管理员角色
        /// </summary>
        public Task<(IdentityResult, User?, string? password)> AddAdminUserAsync(string userName, string phoneNumber)
        {
            /*if (await FindByNameAsync(userName) != null)
                return (ErrorResult($"用户名{userName}已经存在"), null, null);
            if (await FindByPhoneNumberAsync(phoneNumber)!=null)
                return (ErrorResult($"手机号{phoneNumber}已经存在"), null, null);
            User user = new User(userName)
            {
                PhoneNumber = phoneNumber,
                PhoneNumberConfirmed = true
            };
            //var password = GeneratePassword();//随机生成一个密码
            var password = "123";//不随机了，初始密码给123就好了
            var result = await CreateAsync(user, password);
            if (!result.Succeeded) return (result, null, null);
            result = await AddToRoleAsync(user, "Admin");
            if (!result.Succeeded) return (result, null, null);
            return (IdentityResult.Success, user, password);*/
            return AddUserAsync(userName, phoneNumber, "Admin");
        }


        /// <summary>
        /// 创建普通用户，并指定角色
        /// </summary>
        public async Task<(IdentityResult, User?, string? password)> AddUserAsync(string userName, string phoneNumber,string roleName)
        {
            if (await FindByNameAsync(userName) != null)
                return (ErrorResult($"用户名{userName}已经存在"), null, null);
            if (await FindByPhoneNumberAsync(phoneNumber)!=null)
                return (ErrorResult($"手机号{phoneNumber}已经存在"), null, null);
            User user = new User(userName)
            {
                PhoneNumber = phoneNumber,
                PhoneNumberConfirmed = true
            };
            //var password = GeneratePassword();//随机生成一个密码
            var password = "123";//不随机了，初始密码给123就好了
            var result = await CreateAsync(user, password);
            if (!result.Succeeded) return (result, null, null);
            result = await AddToRoleAsync(user, roleName);
            if (!result.Succeeded) return (result, null, null);
            return (IdentityResult.Success, user, password);
        }


        public async Task<(IdentityResult, User?, string? password)> ResetPasswordAsync(Guid id)
        {
            var user = await FindByIdAsync(id);
            if (user == null) return (ErrorResult("用户没找到"), null, null);
            //string password = GeneratePassword();
            var password = "123";
            string token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var result = await _userManager.ResetPasswordAsync(user, token, password);
            if(!result.Succeeded) return (result, null, null);
            return (IdentityResult.Success, user, password);
        }
    }
}
