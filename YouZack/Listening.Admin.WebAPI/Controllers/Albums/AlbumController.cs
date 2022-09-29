using Listening.Domain.Entities;
using Listening.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Listening.Admin.WebAPI.Controllers.Albums
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    [UnitOfWork(typeof(ListeningDbContext))]
    public class AlbumController : ControllerBase
    {
        private readonly ListeningDbContext _dbContext;
        private readonly ListeningDomainService _domainService;
        private readonly IListeningRepository _repository;
        public AlbumController(ListeningDbContext dbContext, ListeningDomainService domainService, IListeningRepository repository)
        {
            _dbContext = dbContext;
            _domainService = domainService;
            _repository = repository;
        }

        [HttpGet("All/{categoryId}")]
        public Task<Album[]> FindAllByCategoryId([RequiredGuid] Guid categoryId)
        {
            return _repository.GetAlbumsByCategoryIdAsync(categoryId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Album?>> FindById([RequiredGuid] Guid id)
        {
            var album =await _repository.GetAlbumByIdAsync(id);
            if (album == null) return NotFound($"没有Id={id}的Episode");
            return album;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Add(AlbumAddRequest request)
        {
            Album album = await _domainService.AddAlbumAsync(request.CategoryId, request.Name);
            _dbContext.Add(album);
            return album.Id;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([RequiredGuid] Guid id, AlbumUpdateRequest request)
        {
            var album = await _repository.GetAlbumByIdAsync(id);
            if (album == null) return NotFound($"没有Id={id}的Album");
            album.ChangeName(request.Name);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([RequiredGuid] Guid id)
        {
            var album = await _repository.GetAlbumByIdAsync(id);
            //这样做仍然是幂等的，因为“调用N次，确保服务器处于与第一次调用相同的状态。”与响应无关
            if (album == null) return NotFound($"没有Id={id}的Album");
            album.SoftDelete();
            return Ok();
        }
        [HttpPut("Hide/{id}")]
        public async Task<ActionResult> Hide([RequiredGuid] Guid id)
        {
            var album = await _repository.GetAlbumByIdAsync(id);
            if (album == null) return NotFound($"没有Id={id}的Album");
            album.Hide();
            return Ok();
        }
        [HttpPut("Show/{id}")]
        public async Task<ActionResult> Show([RequiredGuid] Guid id)
        {
            var album = await _repository.GetAlbumByIdAsync(id);
            if (album == null) return NotFound($"没有Id={id}的Album");
            album.Show();
            return Ok();
        }

        [HttpPut("Sort/{categoryId}")]
        public async Task<ActionResult> Sort([RequiredGuid] Guid categoryId, AlbumsSortRequest request)
        {
            await _domainService.SortAlbumsAsync(categoryId, request.SortedAlbumIds);
            return Ok();
        }
    }
}
