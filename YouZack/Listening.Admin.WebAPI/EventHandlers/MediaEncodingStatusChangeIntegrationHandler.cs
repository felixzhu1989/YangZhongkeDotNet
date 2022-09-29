using Listening.Admin.WebAPI.Hubs;
using Listening.Infrastructure;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zack.EventBus;

namespace Listening.Domain.Events
{
    //NuGet安装：Install-Package Zack.EventBus
    //收听转码服务发出的集成事件
    //把状态通过SignalR推送给客户端，从而显示“转码进度”
    [EventName("MediaEncoding.Started")]
    [EventName("MediaEncoding.Failed")]
    [EventName("MediaEncoding.Duplicated")]
    [EventName("MediaEncoding.Completed")]
    class MediaEncodingStatusChangeIntegrationHandler : DynamicIntegrationEventHandler
    {
        private readonly ListeningDbContext _dbContext;
        private readonly EncodingEpisodeHelper _encodingEpisodeHelper;
        private readonly IHubContext<EpisodeEncodingStatusHub> _hubContext;
        private readonly IListeningRepository _repository;
        public MediaEncodingStatusChangeIntegrationHandler(ListeningDbContext dbContext,EncodingEpisodeHelper encodingEpisodeHelper,IHubContext<EpisodeEncodingStatusHub> hubContext,IListeningRepository repository)
        {
            _dbContext = dbContext;
            _encodingEpisodeHelper = encodingEpisodeHelper;
            _hubContext = hubContext;
            _repository = repository;
        }
        public override async Task HandleDynamic(string eventName, dynamic eventData)
        {
            string sourceSystem = eventData.SourceSystem;
            //可能是别的系统的转码消息
            if (sourceSystem != "Listening") return;
            Guid id = Guid.Parse(eventData.Id);//EncodingItem的Id就是Episode 的Id
            switch (eventName)
            {
                case "MediaEncoding.Started":
                    await _encodingEpisodeHelper.UpdateEpisodeStatusAsync(id, "Started");
                    //通知前端刷新
                    await _hubContext.Clients.All.SendAsync("OnMediaEncodingStarted", id);
                    break;
                case "MediaEncoding.Failed":
                    await _encodingEpisodeHelper.UpdateEpisodeStatusAsync(id, "Failed");
                    //todo: 这样做有问题，这样就会把消息发送给所有打开这个界面的人，应该用connectionId、userId等进行过滤，
                    await _hubContext.Clients.All.SendAsync("OnMediaEncodingFailed", id);
                    break;
                case "MediaEncoding.Duplicated":
                    await _encodingEpisodeHelper.UpdateEpisodeStatusAsync(id, "Completed");
                    //通知前端刷新
                    await _hubContext.Clients.All.SendAsync("OnMediaEncodingCompleted", id);
                    break;
                case "MediaEncoding.Completed":
                    //转码完成，则从Redis中把暂存的Episode信息取出来，然后正式地插入Episode表中
                    await _encodingEpisodeHelper.UpdateEpisodeStatusAsync(id, "Completed");
                    Uri outputUrl=new Uri(eventData.OutputUrl);
                    var encodingItem = await _encodingEpisodeHelper.GetEncodingEpisodeAsync(id);
                    Guid albumId=encodingItem.AlbumId;
                    int maxSeq = await _repository.GetMaxSeqOfAlbumsAsync(albumId);
                    var builder = new Episode.Builder();
                    builder.Id(id).SequenceNumber(maxSeq + 1).Name(encodingItem.Name)
                        .AlbumId(albumId).AudioUrl(outputUrl).DurationInSecond(encodingItem.DurationInSecond)
                        .SubtitleType(encodingItem.SubtitleType).Subtitle(encodingItem.Subtitle);
                    var episode = builder.Build();
                    _dbContext.Add(episode);
                    await _dbContext.SaveChangesAsync();
                    //通知前端刷新
                    await _hubContext.Clients.All.SendAsync("OnMediaEncodingCompleted", id);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eventName));
            }
        }
    }
}
