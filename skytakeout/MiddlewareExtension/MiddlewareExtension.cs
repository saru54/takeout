using skytakeout.Middleware;

namespace skytakeout.MiddlewareExtension
{
    public static class MiddlewareExtension
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalExceptionMiddleware>();
            return app;
        }
    }
}
