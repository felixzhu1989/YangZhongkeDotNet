using Listening.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listening.Admin.WebAPI.Controllers.Categories
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    [UnitOfWork(typeof(ListeningDbContext))]
    //供后台用的增删改查接口不用缓存
    public class CategoryController : ControllerBase
    {
        private readonly ListeningDbContext _dbContext;
        private readonly ListeningDomainService _domainService;
        private readonly IListeningRepository _repository;
        public CategoryController(ListeningDbContext dbContext, ListeningDomainService domainService, IListeningRepository repository)
        {
            _dbContext = dbContext;
            _domainService = domainService;
            _repository = repository;
        }

        [HttpGet("All")]
        public Task<Category[]> FillAll()
        {
            return _repository.GetCategoriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category?>> FindById([RequiredGuid] Guid id)
        {
            //返回ValueTask的需要await的一下
            var category = await _repository.GetCategoryByIdAsync(id);
            if (category == null) return NotFound($"没有Id={id}的Category");
            return category;
        }

        [HttpPost("Add")]
        public async Task<ActionResult<Guid>> Add(CategoryAddRequest request)
        {
            var category = await _domainService.AddCategoryAsync(request.Name, request.CoverUrl);
            await _dbContext.AddAsync(category);
            return category.Id;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([RequiredGuid] Guid id, CategoryUpdateRequest request)
        {
            var category = await _repository.GetCategoryByIdAsync(id);
            if (category == null) return NotFound($"没有Id={id}的Category");
            category.ChangeName(request.Name);
            category.ChangeCoverUrl(request.CoverUrl);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([RequiredGuid] Guid id)
        {
            var category = await _repository.GetCategoryByIdAsync(id);
            //这样做仍然是幂等的，因为“调用N次，确保服务器处于与第一次调用相同的状态。”与响应无关
            if (category == null) return NotFound($"没有Id={id}的Category");
            category.SoftDelete();//软删除
            return Ok();
        }

        [HttpPut("Sort")]
        public async Task<ActionResult> Sort(CategoriesSortRequest request)
        {
            await _domainService.SortCategoriesAsync(request.SortedCategoryIds);
            return Ok();
        }
    }
}
