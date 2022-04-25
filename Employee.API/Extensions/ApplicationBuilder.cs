using Employee.API.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Employee.API.Extensions
{
    public static class ApplicationBuilder
    {
        public static void UseSwaggerUIBuilder(this IApplicationBuilder builder)
        {
            builder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Employee.API v1");
                c.DocumentTitle = "Employee API";
                c.RoutePrefix = string.Empty;
            });
        }
        
        public static void UseMiddleware(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ErrorMiddleware>();
        }
    }
}