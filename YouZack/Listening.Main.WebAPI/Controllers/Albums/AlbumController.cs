using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listening.Main.WebAPI.Controllers.Albums
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IListeningRepository _repository;
        private readonly IMemoryCacheHelper _cacheHelper;
        public AlbumController(IListeningRepository repository,IMemoryCacheHelper cacheHelper)
        {
            _repository = repository;
            _cacheHelper = cacheHelper;
        }
        [HttpGet("All/{categoryId}")]
        public async Task<ActionResult<AlbumViewModel[]>> FindByCategoryId([RequiredGuid] Guid categoryId)
        {
            //写到单独的local函数的好处是避免回调中代码太复杂
            Task<Album[]> FindDataAsync()
            {
                return _repository.GetAlbumsByCategoryIdAsync(categoryId);
            }
            var task = _cacheHelper.GetOrCreateAsync($"AlbumController.FindByCategoryId.{categoryId}",
                async (e) => AlbumViewModel.Create(await FindDataAsync()));
            return await task;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<AlbumViewModel>> FindById([RequiredGuid] Guid id)
        {
            var album = await _cacheHelper.GetOrCreateAsync($"AlbumController.FindById.{id}",
                async (e) => AlbumViewModel.Create(await _repository.GetAlbumByIdAsync(id)));
            if (album == null) return NotFound($"没有Id={id}的Album");
            return album;
        }
    }
}
