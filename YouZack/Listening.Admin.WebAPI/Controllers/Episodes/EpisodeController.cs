using Listening.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Zack.EventBus;

namespace Listening.Admin.WebAPI.Controllers.Episodes
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    [UnitOfWork(typeof(ListeningDbContext))]
    public class EpisodeController : ControllerBase
    {
        private readonly ListeningDbContext _dbContext;
        private readonly ListeningDomainService _domainService;
        private readonly IListeningRepository _repository;
        private readonly IEventBus _eventBus;
        private readonly EncodingEpisodeHelper _encodingEpisodeHelper;
        public EpisodeController(ListeningDbContext dbContext,ListeningDomainService domainService,IListeningRepository repository,IEventBus eventBus,EncodingEpisodeHelper encodingEpisodeHelper)
        {
            _dbContext = dbContext;
            _domainService = domainService;
            _repository = repository;
            _eventBus = eventBus;
            _encodingEpisodeHelper = encodingEpisodeHelper;
        }
        [HttpGet("All/{albumId}")]
        public Task<Episode[]> FindAllByAlbumId([RequiredGuid] Guid albumId)
        {
            return _repository.GetEpisodesByAlbumIdAsync(albumId);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Episode?>> FindById([RequiredGuid] Guid id)
        {
            //因为这是后台系统，所以不在乎把 Episode全部内容返回给客户端的问题，以后如果开放给外部系统再定义ViewModel
            var episode =await _repository.GetEpisodeByIdAsync(id);
            if (episode == null) return NotFound($"没有Id={id}的Episode");
            return episode;
        }
        [HttpPost]
        public async Task<ActionResult<Guid>> Add(EpisodeAddRequest request)
        {
            //如果上传的是m4a，不用转码，直接存到数据库
            if (request.AudioUrl.ToString().EndsWith("m4a", StringComparison.OrdinalIgnoreCase))
            {
                Episode episode = await _domainService.AddEpisodeAsync(request.AlbumId, request.Name, request.AudioUrl,
                    request.DurationInSecond, request.SubtitleType, request.Subtitle);
                _dbContext.Add(episode);
                return episode.Id;
            }
            else
            {
                //非m4a文件需要先转码，为了避免非法数据污染业务数据，增加业务逻辑麻烦，按照DDD的原则，不完整的Episode不能插入数据库
                //先临时暂存到Redis中，转码完成后再插入数据库
                Guid episodeId=Guid.NewGuid();
                EncodingEpisodeInfo encodingEpisode = new EncodingEpisodeInfo(episodeId, request.Name, request.AlbumId, request.DurationInSecond, request.Subtitle, request.SubtitleType, "Created");
                await _encodingEpisodeHelper.AddEncodingEpisodeAsync(episodeId, encodingEpisode);
                //通知转码,启动转码（【集成事件】，通知转码服务开始转码，在转码服务监听该事件）
                _eventBus.Publish("MediaEncoding.Created",new{MediaId=episodeId,MediaUrl=request.AudioUrl,OutputFormat="m4a",SourceSystem="Listening"});
                return episodeId;
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update([RequiredGuid] Guid id, EpisodeUpdateRequest request)
        {
            var episode = await _repository.GetEpisodeByIdAsync(id);
            if(episode == null) return NotFound($"没有Id={id}的Episode");
            episode.ChangeName(request.Name);
            episode.ChangeSubtitle(request.SubtitleType, request.Subtitle);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete([RequiredGuid] Guid id)
        {
            var episode = await _repository.GetEpisodeByIdAsync(id);
            //这样做仍然是幂等的，因为“调用N次，确保服务器处于与第一次调用相同的状态。”与响应无关
            if (episode == null) return NotFound($"没有Id={id}的Episode");
            episode.SoftDelete();//软删除
            return Ok();
        }
        //获取albumId下所有的转码任务
        [HttpGet("Encoding/{albumId}")]
        public async Task<ActionResult<EncodingEpisodeInfo[]>> FindEncodingEpisodesByAlbumId(
            [RequiredGuid] Guid albumId)
        {
            List<EncodingEpisodeInfo> list=new List<EncodingEpisodeInfo>();
            var episodeIds = await _encodingEpisodeHelper.GetEncodingEpisodeIdsAsync(albumId);
            foreach (var episodeId in episodeIds)
            {
                var encodingEpisode = await _encodingEpisodeHelper.GetEncodingEpisodeAsync(episodeId);
                //不显示已经完成的
                if (!encodingEpisode.Status.EqualsIgnoreCase("Completed")) list.Add(encodingEpisode);
            }
            return list.ToArray();
        }

        [HttpPut("Hide/{id}")]
        public async Task<ActionResult> Hide([RequiredGuid] Guid id)
        {
            var episode = await _repository.GetEpisodeByIdAsync(id);
            if (episode == null) return NotFound($"没有Id={id}的Episode");
            episode.Hide();
            return Ok();
        }
        [HttpPut("Show/{id}")]
        public async Task<ActionResult> Show([RequiredGuid] Guid id)
        {
            var episode = await _repository.GetEpisodeByIdAsync(id);
            if (episode == null) return NotFound($"没有Id={id}的Episode");
            episode.Show();
            return Ok();
        }
        [HttpPut("Sort/{albumId}")]
        public async Task<ActionResult> Sort([RequiredGuid] Guid albumId, EpisodesSortRequest request)
        {
            await _domainService.SortEpisodesAsync(albumId, request.SortedEpisodeIds);
            return Ok();
        }
    }
}
