using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityCoreApp.Application.Interfaces;
using IdentityCoreApp.Application.ViewModels.System;
using IdentityCoreApp.Data.Entities;
using IdentityCoreApp.Extensions;
using IdentityCoreApp.Models.AccountViewModels;
using IdentityCoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IdentityCoreApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            if (User.GetSpecificClaim("Email").ToString().Equals(""))
            {
                return Redirect("/Account/Login");
            }
            return View();
        }

        [HttpPut]
        public async Task<IActionResult> SaveEntity(AppUserViewModel userVm)
        {
            if (!ModelState.IsValid)
            {
                IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);
                return new ObjectResult(new GenericResult(false, allErrors));
            }
            if (userVm.Id == null)
            {
                await _userService.AddAsync(userVm);
            }
            else
            {
                await _userService.UpdateAsync(userVm);
            }
            return new ObjectResult(new GenericResult(true, "Cập nhật thành công"));
        }

    }
}