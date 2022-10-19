﻿namespace SearchService.Domain
{
    public interface ISearchRepository
    {
        public Task UpsertAsync(Episode episode);
        public Task DeleteAsync(Guid episodeId);
        public Task<SearchEpisodesResponse> SearchEpisodes(string keyword, int pageIndex, int pageSize);
    }
}