using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationIdentity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly UserManager<MyUser> _userManager;
        public DemoController(UserManager<MyUser> userManager)
        {
            _userManager = userManager;
        }

        //新增用户操作
        [HttpPost]
        public async Task<ActionResult> AddUser(AddUserRequest request)
        {
            MyUser user=new MyUser(){UserName = request.UserName,Email = request.Email};
            await _userManager.CreateAsync(user, request.Password);
            return Ok();
        }

    }
}
