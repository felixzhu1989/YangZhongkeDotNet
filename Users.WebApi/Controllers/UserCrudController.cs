using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Users.Domain;
using Users.Domain.Entities;
using Users.Infrastructure;

namespace Users.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCrudController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly UserDbContext _context;
        public UserCrudController(IUserRepository userRepository, UserDbContext context)
        {
            _userRepository = userRepository;
            _context = context;
        }
        [HttpPost("add")]
        [UnitOfWork(typeof(UserDbContext))]
        public async Task<IActionResult> AddUser(AddUserRequest request)
        {
            var user = await _userRepository.FindOneAsync(request.PhoneNumber);
            if (user != null) return BadRequest("手机号已被注册");
            var newUser = new User(request.PhoneNumber);
            newUser.ChangePassword(request.Password);
            await _context.Users.AddAsync(newUser);
            //不用手动调用SaveChanges，因为标注了UnitOfWork，会自动提交事务
            return Ok("用户添加成功");
        }
    }
}
