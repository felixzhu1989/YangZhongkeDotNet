using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationFilter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly MyDbContext _dbContext;
        public DemoController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public async Task<string> Test()
        {
            /*//一个SaveChanges就是一个事务
            //在每个Add下加上SaveChanges，分成两个事务提交，如果后面的失败了不影响前面提交
            await _dbContext.Persons.AddAsync(new Person { Name = "xfg", Age = 20 });
            await _dbContext.SaveChangesAsync();
            //故意构造一个错误的日期，导致提交失败，观察前面的是否提交
            await _dbContext.Books.AddAsync(new Book { Title = ".NET书", AuthorName = "hhh", Price = 40, PubTime = new DateTime(2018, 15, 5) });
            await _dbContext.SaveChangesAsync();*/

            //使用TransactionScope，让两个事务包裹成一个事务
            using TransactionScope transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            await _dbContext.Persons.AddAsync(new Person { Name = "kkk", Age = 20 });
            await _dbContext.SaveChangesAsync();
            await _dbContext.Books.AddAsync(new Book { Title = ".NET书", AuthorName = "hhh", Price = 40, PubTime = new DateTime(2018, 8, 5) });
            await _dbContext.SaveChangesAsync();
            transactionScope.Complete();

            return await Task.FromResult("Ok");
        }


    }
}
