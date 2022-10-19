namespace Listening.Main.WebAPI.Controllers.Categories
{
    public record CategoryViewModel(Guid id, MultilingualString Name,Uri CoverUrl)
    {
        public static CategoryViewModel? Create(Category? x)
        {
            if(x==null) return null;
            return new CategoryViewModel(x.Id, x.Name, x.CoverUrl);
        }
        public static CategoryViewModel[] Create(Category[] items)
        {
            return items.Select(x => Create(x)!).ToArray();
        }
    }
}
