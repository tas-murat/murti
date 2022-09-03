using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Extensions
{
    public static class ExceptionCustomMiddlewareExtentions
    {
        public static void ConfigureCustomExcepitonMiddlewareForView(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionCustomMiddleware>();
        }
    }
}
