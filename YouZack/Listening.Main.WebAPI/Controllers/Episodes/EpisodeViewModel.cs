namespace Listening.Main.WebAPI.Controllers.Episodes
{
    public record EpisodeViewModel(Guid Id,MultilingualString Name,Guid AlbumId,Uri AudioUrl,double DurationInSecond,IEnumerable<SentenceViewModel>? Sentences)
    {
        public static EpisodeViewModel? Create(Episode? e, bool loadSubtitle)
        {
            if (e == null) return null;
            List<SentenceViewModel> sentenceViewModels = new();
            if (loadSubtitle)
            {
                var sentences = e.ParseSubtitle();
                foreach (var sentence in sentences)
                {
                    SentenceViewModel vm = new SentenceViewModel(sentence.StartTime.TotalSeconds,
                        sentence.EndTime.TotalSeconds, sentence.Content);
                    sentenceViewModels.Add(vm);
                }
            }
            return new EpisodeViewModel(e.Id, e.Name, e.AlbumId, e.AudioUrl, e.DurationInSecond, sentenceViewModels);
        }
        public static EpisodeViewModel[] Create(Episode[] items, bool loadSubtitle)
        {
            return items.Select(e => Create(e, loadSubtitle)!).ToArray();
        }
    }
}
