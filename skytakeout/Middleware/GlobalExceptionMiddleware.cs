
using commen;
using commen.Constant;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace skytakeout.Middleware
{
    public class GlobalExceptionMiddleware 
    {
        private readonly RequestDelegate next;
        private readonly ILogger<GlobalExceptionMiddleware> logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                logger.LogInformation("进入全局异常处理");
                await next.Invoke(context);
            }catch (Exception ex)
            {
                logger.LogInformation("处理全局异常");
                await HandleExceptionAsync(context, ex);
                logger.LogInformation("处理完成");
            }
        }
        public static async Task HandleExceptionAsync(HttpContext context , Exception exception)
        {
            context.Response.ContentType = "application/json";
            var reuslt = JsonConvert.SerializeObject(Result<string>.Error(ErrorConstant.UnknownError));
            await context.Response.WriteAsync(reuslt);
        }
        
    }
}
