namespace WebApplicationJwt
{
    public class JwtOptions
    {
        public string SigningKey { get; set; }
        public int ExpireSeconds { get; set; }
    }
}
