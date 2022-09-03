using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Filters;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        private IPostService _postService;


        public HomeController(IPostService postService)
        {
            _postService = postService;
        }

       
        //[HandleExceptionAttribute]
        public IActionResult Index()
        {
            var result = _postService.GetList();
          
            return View(result.Data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {

            return View(new ErrorViewModel { StatusCode = HttpContext.Response.StatusCode,RequestId=HttpContext.Response.ToString() });
        }
    }
}
