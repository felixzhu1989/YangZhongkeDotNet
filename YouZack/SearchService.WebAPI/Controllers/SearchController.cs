using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchService.Domain;
using Zack.EventBus;

namespace SearchService.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchRepository _repository;
        private readonly IEventBus _eventBus;
        public SearchController(ISearchRepository repository,IEventBus eventBus)
        {
            _repository = repository;
            _eventBus = eventBus;
        }

        [HttpGet]
        public Task<SearchEpisodesResponse> SearchEpisodes([FromQuery] SearchEpisodesRequest request)
        {
            return _repository.SearchEpisodes(request.Keyword, request.PageIndex, request.PageSize);
        }

        [HttpPut]
        public Task<IActionResult> ReIndexAll()
        {
            //避免耦合，这里发送ReIndexAll的集成事件
            //所有向搜索系统贡献数据的系统都可以响应这个事件，重新贡献数据
            _eventBus.Publish("SearchService.ReIndexAll", null);
            return Task.FromResult<IActionResult>(Ok());
        }
    }
}
