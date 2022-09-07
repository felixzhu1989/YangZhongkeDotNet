namespace WebApplicationSignalR
{
    //不检查JwtVersion自定义特性
    [AttributeUsage(AttributeTargets.Method)]//指定用到方法上
    public class NotJwtVersionCheckAttribute:Attribute
    {
    }
}
