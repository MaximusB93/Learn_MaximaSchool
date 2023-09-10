namespace TestWebAPI.CustomMiddleWare;

public class LogUrlMiddleware
{
    private readonly RequestDelegate _requestDelegate;

    public LogUrlMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"Log request: {context.Request}");
        await _requestDelegate(context);
    }
}

public static class LogUrlExstensions
{
    public static IApplicationBuilder UseLogUrls(this IApplicationBuilder app)
    {
        return app.UseMiddleware<LogUrlMiddleware>();
    }
}