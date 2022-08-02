using ReadWebConfig;

namespace Microsoft.Extensions.Configuration
{
    public static class FxConfigExtensions
    {
        public static IConfigurationBuilder AddFxConfig(this IConfigurationBuilder builder,
            string? path = null)
        {
            path ??= "web.config";
            return builder.Add(new FxConfigSource{ Path = path });
        }
    }
}
