using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public ActionResult<LoginResponse> Login(LoginRequest request)
        {
            if (request.UserName == "admin" && request.Password == "123456")
            {
                var process = Process.GetProcesses().Select(p => new ProcessInfo(p.Id, p.ProcessName, p.WorkingSet64))
                    .ToArray();
                return new LoginResponse(true, process);
            }
            else return new LoginResponse(false, null);
        }
    }
}
