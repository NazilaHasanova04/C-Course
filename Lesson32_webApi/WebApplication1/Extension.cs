namespace WebApplication1
{
    static public class Extension
    {
        public static IApplicationBuilder UseHello(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<CustomMiddleware>();
        }
    }
}
