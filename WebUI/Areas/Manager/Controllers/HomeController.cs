using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebUI.Areas.Manager.Models;
using Core.Extensions;
using Business.Abstract;
using System.Collections.Generic;

namespace WebUI.Areas.Manager.Controllers
{
    [Area("manager")]
    public class HomeController : Controller
    {
        IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();
            var user = Response.HttpContext.User;
            List<string> emailList = user.Claims(ClaimTypes.Email);

         
            if (emailList != null && emailList.Count>0)
            {
                var currentuser = _userService.GetByMail(emailList[0]);
                homeViewModel.currentUser = currentuser;
            }
            
            return View(homeViewModel);
        }

       
    }
}
