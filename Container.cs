internal static class Container
{
    public const string Image = "ghcr.io/meziantou/meziantou-git-hub-actions-tracing:1.0.42";
    public static readonly object RedisImage = ImageSource.FromRegistry("redis:8.2");
}