using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Listening.Main.WebAPI.Controllers.Episodes
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IListeningRepository _repository;
        private readonly IMemoryCacheHelper _cacheHelper;
        public EpisodeController(IListeningRepository repository,IMemoryCacheHelper cacheHelper)
        {
            _repository = repository;
            _cacheHelper = cacheHelper;
        }
        [HttpGet("All/{albumId}")]
        public async Task<ActionResult<EpisodeViewModel[]>> FindByAlbumId([RequiredGuid] Guid albumId)
        {
            Task<Episode[]> FindDataAsync()
            {
                return _repository.GetEpisodesByAlbumIdAsync(albumId);
            }
            //加载Episode列表的，默认不加载Subtitle，这样降低流量大小
            var task = _cacheHelper.GetOrCreateAsync($"EpisodeController.FindByAlbumId.{albumId}",
                async (e) => EpisodeViewModel.Create(await FindDataAsync(), false));
            return await task;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<EpisodeViewModel>> FindById([RequiredGuid] Guid id)
        {
            var episode = await _cacheHelper.GetOrCreateAsync($"EpisodeController.FindById.{id}",
                async (e) => EpisodeViewModel.Create(await _repository.GetEpisodeByIdAsync(id), true));
            if (episode == null) return NotFound($"没有Id={id}的Episode");
            return episode;
        }
    }
}
