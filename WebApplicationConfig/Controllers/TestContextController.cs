using EFCoreBooks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestContextController : ControllerBase
    {
        private readonly MyDbContext _dbContext;

        public TestContextController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet]
        public string Get()
        {
           return $"Total Books:{_dbContext.Books.Count()}";
        }
    }
}
