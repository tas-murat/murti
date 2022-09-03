using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace WebUI.Extensions
{
    public class ExceptionCustomMiddleware
    {
     private   RequestDelegate _next;
        public ExceptionCustomMiddleware(RequestDelegate next)
        { 
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {

                await HandleExceptionAsync(context, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            context.Response.ContentType = "text/html";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = "Internal Server Error";
           
            if (e.GetType() == typeof(FluentValidation.ValidationException))
            {
                message=e.Message;
            }


            return context.Response.WriteAsync(new ErrorDetails
            {
                StatusCode=context.Response.StatusCode,
                Message= message,
            }.ToString());
        }
    }
}
