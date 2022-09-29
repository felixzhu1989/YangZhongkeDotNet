using System.Security.Claims;
using IdentityService.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Zack.JWT;

namespace IdentityService.Domain
{
    /// <summary>
    /// 领域服务，体现主要业务逻辑
    /// </summary>
    public class IdDomainService
    {
        //NuGet安装：Install-Package Zack.JWT
        private readonly IIdRepository _repository;//Identity仓储
        private readonly ITokenService _tokenService;//发放令牌服务，由Zack.JWT封装
        private readonly IOptions<JWTOptions> _optJwt;//JWT选项，通过配置读取（存储在中心化配置服务器）

        public IdDomainService(IIdRepository repository,ITokenService tokenService,IOptions<JWTOptions> optJwt)
        {
            _repository = repository;
            _tokenService = tokenService;
            _optJwt = optJwt;
        }

        private async Task<SignInResult> CheckUserNameAndPwdAsync(string userName, string password)
        {
            //如果用户不存在，则返回登录失败
            var user = await _repository.FindByNameAsync(userName);
            if(user == null)return SignInResult.Failed;
            //CheckForSignInAsync会对于多次重复失败进行账号禁用
            var result = await _repository.CheckForSignInAsync(user, password, true);
            return result;
        }

        private async Task<SignInResult> CheckPhoneNumberAndPwdAsync(string phoneNumber, string password)
        {
            //如果用户不存在，则返回登录失败
            var user = await _repository.FindByPhoneNumberAsync(phoneNumber);
            if (user == null) return SignInResult.Failed;
            var result = await _repository.CheckForSignInAsync(user, password, true);
            return result;
        }

        //元组语法，(SignInResult Result, string? Token)
        /// <summary>
        /// 使用用户名和密码登录，登入成功则返回令牌
        /// </summary>
        public async Task<(SignInResult result, string? token)> LoginByUserNameAndPwdAsync(string userName,
            string password)
        {
            //检查用户名和密码，通过则发放令牌
            var checkResult=await CheckUserNameAndPwdAsync(userName, password);
            if (checkResult.Succeeded)
            {
                var user = await _repository.FindByNameAsync(userName);
                string token = await BuildTokenAsync(user);
                return (SignInResult.Success, token);
            }
            else
            {
                return (checkResult, null);
            }
        }

        public async Task<(SignInResult result, string? token)> LoginByPhoneAndPwdAsync(string phoneNumber,
            string password)
        {
            var checkResult=await CheckPhoneNumberAndPwdAsync(phoneNumber, password);
            if (checkResult.Succeeded)
            {
                var user = await _repository.FindByPhoneNumberAsync(phoneNumber);
                string token = await BuildTokenAsync(user);
                return (SignInResult.Success, token);
            }
            else
            {
                return (checkResult, null);
            }
        }

        private async Task<string> BuildTokenAsync(User user)
        {
            var roles = await _repository.GetRolesAsync(user);//获取用户角色，放在token的负载中
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role,role));
            }
            return _tokenService.BuildToken(claims, _optJwt.Value);
        }
    }
}
