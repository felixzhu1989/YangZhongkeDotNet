namespace WebApplicationFilter
{
    [AttributeUsage(AttributeTargets.Method)]
    public class NotTransactionalAttribute:Attribute
    {
    }
}
