namespace WebApplicationCustomMiddleware.MiniWebApi
{
    public class ActionFilters
    {
        public static List<IMyActionFilter> Filters = new List<IMyActionFilter>();
    }

    public interface IMyActionFilter
    {
        void Execute();
    }
}
