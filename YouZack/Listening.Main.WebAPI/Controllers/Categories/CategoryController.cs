using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listening.Main.WebAPI.Controllers.Categories
{
    [Route("api/[controller]")]
    [ApiController]
    //供后台用的增删改查接口不用缓存
    public class CategoryController : ControllerBase
    {
        //尽管这里的FindAll、FindById和Admin.WebAPI中类似，但是不应该复用。因为Admin.WebAPI中的操作没有缓存，
        //而Main.WebAPI中的则有缓存
        private readonly IListeningRepository _repository;
        private readonly IMemoryCacheHelper _cacheHelper;
        public CategoryController(IListeningRepository repository,IMemoryCacheHelper cacheHelper)
        {
            _repository = repository;
            _cacheHelper = cacheHelper;
        }
        [HttpGet("All")]
        public async Task<ActionResult<CategoryViewModel[]>> FindAll()
        {
            //方法的内部方法
            Task<Category[]> FindDataAsync()
            {
                return _repository.GetCategoriesAsync();
            }
            //用AOP来进行缓存控制看起来更优美（可以用国产的AspectCore或者Castle DynamicProxy），
            //但是这样反而不灵活，因为缓存对于灵活性要求更高，
            //所以用这种直接用ICacheHelper的不优美的方式更实用。
            var task = _cacheHelper.GetOrCreateAsync("CategoryController.FindAll",
                async (e) => CategoryViewModel.Create(await FindDataAsync()));
            return await task;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryViewModel?>> FindById([RequiredGuid] Guid id)
        {
            var category = await _cacheHelper.GetOrCreateAsync($"CategoryController.FindById.{id}",
                async (e) => 
                    CategoryViewModel.Create(await _repository.GetCategoryByIdAsync(id)));
            //返回ValueTask的需要await的一下
            if (category == null) return NotFound($"没有Id={id}的Category");
            return category;
        }
    }
}
