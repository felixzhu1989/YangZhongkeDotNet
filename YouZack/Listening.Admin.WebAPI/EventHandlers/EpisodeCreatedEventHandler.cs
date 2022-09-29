﻿using Listening.Domain.Events;
using Zack.EventBus;

namespace Listening.Admin.WebAPI.EventHandlers
{
    public class EpisodeCreatedEventHandler : INotificationHandler<EpisodeCreatedEvent>
    {
        private readonly IEventBus _eventBus;
        public EpisodeCreatedEventHandler(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }
        public Task Handle(EpisodeCreatedEvent notification, CancellationToken cancellationToken)
        {
            //把领域事件转发为集成事件，让其他微服务听到
            //(Domain)在领域事件处理中集中进行更新缓存等处理，而不是写到Controller中。
            //因为项目中有可能不止一个地方操作领域对象，这样就就统一了操作。
            var episode = notification.Value;
            var sentences = episode.ParseSubtitle();
            //发布集成事件，实现搜索索引、记录日志等功能
            _eventBus.Publish("ListeningEpisode.Created",new{episode.Id,episode.Name, Sentences = sentences,episode.AlbumId,episode.Subtitle,episode.SubtitleType});
            return Task.CompletedTask;
        }
    }
}
