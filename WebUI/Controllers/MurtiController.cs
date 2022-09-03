using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class MurtiController : Controller
    {
        private IAuthService _authService;
        public MurtiController(IAuthService authService)
        {
            _authService = authService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult customentry()
        {
            UserForLoginDto userForLoginDto=new UserForLoginDto();
            userForLoginDto.Email = Request.Form["email"];
            userForLoginDto.Password = Request.Form["password"];
           
            var userToLogin = _authService.Login(userForLoginDto);
            JsonReturnViewModel<UserForLoginDto> jsonReturnViewModel = new JsonReturnViewModel<UserForLoginDto>();
            if (!userToLogin.Success)
            {
                jsonReturnViewModel.DataJSON = userForLoginDto.ToString();
                jsonReturnViewModel.Success = userToLogin.Success;
                jsonReturnViewModel.Message = userToLogin.Message;
            }
            else
            {
                var result = _authService.CreateAccessToken(userToLogin.Data);
                HttpContext.Session.SetString("Token", result.Data.Token);
                jsonReturnViewModel.Success = result.Success;
                jsonReturnViewModel.Message = result.Message;
            }
            return Json(JsonSerializer.Serialize(jsonReturnViewModel));
        }
       
    }
}
