using System.Diagnostics;

namespace WebApplication1
{
    public class CustomMiddleware
    {
        RequestDelegate _next;
        ILogger<CustomMiddleware> _logger;
        IConfiguration _configuration;
        public CustomMiddleware(RequestDelegate next,ILogger<CustomMiddleware> logger,IConfiguration configuration)
        {
            _next = next;
            _logger = logger;
            _configuration = configuration;
        }
        public async Task Invoke(HttpContext httpContext)
        {
           
            Console.WriteLine("Hello!");

            //https://stackoverflow.com/questions/43403941/how-to-read-asp-net-core-response-body


            var url = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString}";
            _logger.LogInformation($"Request URL: {url}");
            _logger.LogInformation($"Request Method: {httpContext.Request.Method}");
            var watch = Stopwatch.StartNew();
            var startdate = DateTime.UtcNow;
           _logger.LogInformation($"Request started at : {startdate}");
           await _next.Invoke(httpContext);
            var finisheddate = DateTime.UtcNow;

            _logger.LogInformation($"Request finished at : {finisheddate}");
            watch.Stop();
            Console.WriteLine("Goodbye...");
            _logger.LogInformation($"ResponseTime:{watch.ElapsedMilliseconds}ms");
        }
    }
}
