using System.Text;
using Serilog;

namespace LessonTwo.Api.Middlewares;

public class CounterMiddleware
{
    private readonly RequestDelegate _next;
    private static long _counter = 0;

    public CounterMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Log.Information($"Счетчик заходов равен: {_counter}");

        if (context.Request.Path == "/")
        {
            context.Response.StatusCode = 200;
            context.Response.ContentType = "text/plain;charset=utf-8";
            await context.Response.WriteAsync($"Счетчик заходов равен: {_counter}", Encoding.UTF8, CancellationToken.None);

            _counter++;
        }
        else
        {
            await _next.Invoke(context);
        }
    }
}

