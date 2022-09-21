namespace Users.WebApi
{
    [AttributeUsage(AttributeTargets.Method)]//规定本特性只能应用与方法
    public class UnitOfWorkAttribute:Attribute
    {
        public Type[] DbContextTypes { get; init; }
        //params可选参数形式
        public UnitOfWorkAttribute(params Type[] dbContextTypes)
        {
            DbContextTypes=dbContextTypes;
        }
    }
}
