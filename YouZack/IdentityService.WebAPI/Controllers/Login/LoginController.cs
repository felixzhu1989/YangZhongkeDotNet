using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security.Claims;
using IdentityService.Domain;
using IdentityService.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityService.WebAPI.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IdDomainService _idService;
        private readonly IIdRepository _repository;
        public LoginController(IdDomainService idService,IIdRepository repository)
        {
            _idService = idService;
            _repository = repository;
        }

        [HttpPost("Init")]
        public async Task<ActionResult> CreateWorld()
        {
            if (await _repository.FindByNameAsync("admin") != null)
            {
                return StatusCode((int)HttpStatusCode.Conflict, "已经初始化过了");
            }
            var user = new User("admin");
            var result = await _repository.CreateAsync(user, "123");
            Debug.Assert(result.Succeeded);
            var token = await _repository.GenerateChangePhoneNumberTokenAsync(user, "17621290000");
            var cResult = await _repository.ChangePhoneNumberAsync(user.Id, "17621290000", token);
            Debug.Assert(cResult.Succeeded);
            result = await _repository.AddToRoleAsync(user, "User"); 
            Debug.Assert(result.Succeeded);
            result = await _repository.AddToRoleAsync(user, "Admin");
            Debug.Assert(result.Succeeded);
            return Ok();
        }

        //书中的项目只提供根据用户名登录的功能，以及管理员增删改查，像用户主动注册、手机验证码登录等功能都不弄。
        [HttpPost("Phone")]
        public async Task<ActionResult<string?>> LoginByPhoneAndPwd(LoginByPhoneAndPwdRequest request)
        {
            //todo：要通过行为验证码、图形验证码等形式来防止暴力破解
            var (checkResult, token) = await _idService.LoginByPhoneAndPwdAsync(request.PhoneNumber, request.Password);
            if (checkResult.Succeeded) return token;
            if (checkResult.IsLockedOut) return StatusCode((int)HttpStatusCode.Locked, "账号已锁定，请稍后再试");
            return StatusCode((int)HttpStatusCode.BadRequest, "登录失败");

        }

        [HttpPost("Name")]
        public async Task<ActionResult<string?>> LoginByUserNameAndPwd(LoginByUserNameAndPwdRequest request)
        {
            var (checkResult, token) = await _idService.LoginByUserNameAndPwdAsync(request.UserName, request.Password);
            if (checkResult.Succeeded) return token;
            if (checkResult.IsLockedOut) return StatusCode((int)HttpStatusCode.Locked, "账号已锁定，请稍后再试");
            return StatusCode((int)HttpStatusCode.BadRequest, "登录失败");

        }

        [HttpGet("Info")]
        [Authorize]
        public async Task<ActionResult<UserResponse>> GetUserInfo()
        {
            //返回我的信息（当前登录用户）
            Guid userId = Guid.Parse(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user = await _repository.FindByIdAsync(userId);
            if (user == null) return NotFound();//可能用户注销了
            //出于安全考虑，不要机密信息传递到客户端
            //除非确认没问题，否则尽量不要直接把实体类对象返回给前端
            return new UserResponse(user.Id, user.UserName, user.PhoneNumber, user.CreationTime);
        }

        [HttpPost("ChangePwd")]
        [Authorize]
        public async Task<ActionResult> ChangePassword(ChangeMyPasswordRequest request)
        {
            Guid userId=Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var resetPwdResult=await _repository.ChangePasswordAsync(userId, request.Password);
            if (resetPwdResult.Succeeded) return Ok();
            return BadRequest(resetPwdResult.Errors.SumErrors());
        }

    }
}
