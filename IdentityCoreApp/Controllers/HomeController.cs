using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IdentityCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using IdentityCoreApp.Authorization;
using IdentityCoreApp.Extensions;

namespace IdentityCoreApp.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        public readonly IAuthorizationService _authorizationService;

        public HomeController(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }

        public IActionResult Index()
        {
            if (User.GetSpecificClaim("Email").ToString().Equals(""))
            {
                return Redirect("/Account/Login");
            }

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
