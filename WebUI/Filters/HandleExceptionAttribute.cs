﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Filters
{
    public class HandleExceptionAttribute:ExceptionFilterAttribute
    {
        public string ViewName { get; set; } = "Error";
        public Type ExceptionType { get; set; }
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = ViewName };
            var modelDataProvider = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelDataProvider, context.ModelState);
            result.ViewData.Add("HandleException", context.Exception);
           
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}
