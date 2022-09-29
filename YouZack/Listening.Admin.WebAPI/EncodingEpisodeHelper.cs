using StackExchange.Redis;

namespace Listening.Admin.WebAPI
{
    public class EncodingEpisodeHelper
    {
        private readonly IConnectionMultiplexer _redisConn;
        public EncodingEpisodeHelper(IConnectionMultiplexer redisConn)
        {
            _redisConn = redisConn;
        }
        //一个key value对中保存这个albumId下所有的转码中的episodeId
        private static string GetKeyForEncodingEpisodeIdsOfAlbum(Guid albumId)
        {
            return $"Listening.EncodingEpisodeIdsOfAlbum.{albumId}";
        }
        private static string GetStatusKeyForEpisode(Guid episodeId)
        {
            return $"Listening.EncodingEpisode.{episodeId}";
        }
        /// <summary>
        /// 增加待转码的任务的详细信息
        /// </summary>
        public async Task AddEncodingEpisodeAsync(Guid episodeId, EncodingEpisodeInfo episode)
        {
            string redisKeyForEpisode = GetStatusKeyForEpisode(episodeId);
            var db = _redisConn.GetDatabase();
            //保存转码任务详细信息，供完成后插入数据库
            await db.StringSetAsync(redisKeyForEpisode, episode.ToJsonString());
            string keyForEncodingEpisodeIdsOfAlbum = GetKeyForEncodingEpisodeIdsOfAlbum(episode.AlbumId);
            //保存这个album下所有待转码的episodeId
            await db.SetAddAsync(keyForEncodingEpisodeIdsOfAlbum, episodeId.ToString());
        }
        /// <summary>
        /// 获取这个albumId下所有转码任务
        /// </summary>
        public async Task<IEnumerable<Guid>> GetEncodingEpisodeIdsAsync(Guid albumId)
        {
            string keyForEncodingEpisodeIdsOfAlbum = GetKeyForEncodingEpisodeIdsOfAlbum(albumId);
            var db=_redisConn.GetDatabase();
            var values = await db.SetMembersAsync(keyForEncodingEpisodeIdsOfAlbum);
            return values.Select(x => Guid.Parse(x));
        }
        /// <summary>
        /// 删除一个Episode任务
        /// </summary>
        public async Task RemoveEncodingEpisodeAsync(Guid episodeId, Guid albumId)
        {
            string redisKeyForEpisode = GetStatusKeyForEpisode(episodeId);
            var db= _redisConn.GetDatabase();
            await db.KeyDeleteAsync(redisKeyForEpisode);
            string keyForEncodingEpisodeIdsOfAlbum = GetKeyForEncodingEpisodeIdsOfAlbum(albumId);
            await db.SetRemoveAsync(keyForEncodingEpisodeIdsOfAlbum, episodeId.ToString());
        }
        /// <summary>
        /// 修改Episode的转码状态
        /// </summary>
        public async Task UpdateEpisodeStatusAsync(Guid episodeId, string status)
        {
            string redisKeyForEpisode = GetStatusKeyForEpisode(episodeId);
            var db = _redisConn.GetDatabase();
            string json = await db.StringGetAsync(redisKeyForEpisode);
            EncodingEpisodeInfo episode = json.ParseJson<EncodingEpisodeInfo>()!;
            episode = episode with { Status = status };
            await db.StringSetAsync(redisKeyForEpisode, episode.ToJsonString());
        }
        /// <summary>
        /// 获得Episode的转码状态
        /// </summary>
        public async Task<EncodingEpisodeInfo> GetEncodingEpisodeAsync(Guid episodeId)
        {
            string redisKeyForEpisode = GetStatusKeyForEpisode(episodeId);
            var db = _redisConn.GetDatabase();
            string json = await db.StringGetAsync(redisKeyForEpisode);
            EncodingEpisodeInfo episode = json.ParseJson<EncodingEpisodeInfo>()!;
            return episode;
        }
    }
}
