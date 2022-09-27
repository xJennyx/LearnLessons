using LessonTwo.Api.Middlewares;
using Serilog;

namespace LessonTwo.Api.Extensions;

public static class ExtensionsSetupMiddlewarePipeline
{
    public static WebApplication SetupMiddleware(this WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseCounter();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });

        return app;
    }

    public static IApplicationBuilder UseCounter(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CounterMiddleware>();
    }
}

