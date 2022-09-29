using IdentityService.Domain;
using IdentityService.Domain.Entities;
using IdentityService.Infrastructure;
using IdentityService.WebAPI.Events;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zack.EventBus;

namespace IdentityService.WebAPI.Controllers.UserAdmin
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class UserAdminController : ControllerBase
    {
        private readonly IdUserManager _userManager;
        private readonly IEventBus _eventBus;
        private readonly IIdRepository _repository;
        public UserAdminController(IdUserManager userManager,IEventBus eventBus,IIdRepository repository)
        {
            _userManager = userManager;
            _eventBus = eventBus;
            _repository = repository;
        }

        [HttpGet("All")]
        public Task<UserDto[]> FindAllUsers()
        {
            return _userManager.Users.Select(u => UserDto.Create(u)).ToArrayAsync();
        }

        [HttpGet("{id}")]
        public async Task<UserDto> FindById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            return UserDto.Create(user);
        }

        [HttpPost("AddAdmin")]
        //[AllowAnonymous]//创建第一个管理员时使用
        public async Task<ActionResult> AddAdminUser(AddAdminUserRequest request)
        {
            var (results, user, password) =
                await _repository.AddAdminUserAsync(request.UserName, request.PhoneNumber);
            if(!results.Succeeded) return BadRequest(results.Errors.SumErrors());
            //生成的密码短信发给对方
            //可以同时或者选择性的把新增用户的密码短信/邮件/打印给用户(EventHandler中指定操作)
            //体现了领域事件对于代码“高内聚、低耦合”的追求
            var UserCreatedEvent = new UserCreatedEvent(user.Id, request.UserName, password, request.PhoneNumber);
            //发布集成事件
            _eventBus.Publish("IdentityService.User.Created",UserCreatedEvent);
            return Ok();
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult> AddUser(AddUserRequest request)
        {
            var (results, user, password) =
                await _repository.AddUserAsync(request.UserName, request.PhoneNumber,request.RoleName);
            if (!results.Succeeded) return BadRequest(results.Errors.SumErrors());
            var UserCreatedEvent = new UserCreatedEvent(user.Id, request.UserName, password, request.PhoneNumber);
            //发布集成事件
            _eventBus.Publish("IdentityService.User.Created", UserCreatedEvent);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAdminUser(Guid id)
        {
            await _repository.RemoveUserAsync(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAdminUser(Guid id, EditAdminUserRequest request)
        {
            var user=await _repository.FindByIdAsync(id);
            if (user == null) return NotFound("用户没找到");
            user.PhoneNumber=request.PhoneNumber;
            await _userManager.UpdateAsync(user);
            return Ok();
        }

        [HttpPut("ResetPwd/{id}")]
        public async Task<ActionResult> ResetAdminUserPassword(Guid id)
        {
            var (result, user, password) = await _repository.ResetPasswordAsync(id);
            if(!result.Succeeded) return BadRequest(result.Errors.SumErrors());
            //生成密码短信发给对方
            var eventData = new ResetPasswordEvent(user.Id, user.UserName, password, user.PhoneNumber);
            _eventBus.Publish("IdentityService.User.PasswordReset",eventData);
            return Ok();
        }
    }
}
