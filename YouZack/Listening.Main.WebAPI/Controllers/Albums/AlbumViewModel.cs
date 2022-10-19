namespace Listening.Main.WebAPI.Controllers.Albums
{
    public record AlbumViewModel(Guid Id, MultilingualString Name, Guid CategoryId)
    {
        public static AlbumViewModel? Create(Album? x)
        {
            if (x == null) return null;
            return new AlbumViewModel(x.Id, x.Name, x.CategoryId);
        }
        public static AlbumViewModel[] Create(Album[] items)
        {
            return items.Select(x => Create(x)!).ToArray();
        }
    }
}
