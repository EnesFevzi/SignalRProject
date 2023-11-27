using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.WebUI.DTOs.UserDto;

namespace SıgnalRProject.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IValidator<UserLoginDto> _loginValidator;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IValidator<UserLoginDto> loginValidator)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _loginValidator = loginValidator;
         
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto createUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (createUserDto.Password != createUserDto.ConfirmPassword)
            {
                ModelState.AddModelError("", "Şifreler uyuşmuyor.");
                return View();
            }
            if (createUserDto.Password == createUserDto.ConfirmPassword)
            {

				var appUser = new AppUser()
				{
					Name = createUserDto.Name,
					Surname = createUserDto.Surname,
					Email = createUserDto.Mail,
					UserName = createUserDto.Mail,
				};
                var result = await userManager.CreateAsync(appUser, createUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Auth");
                }

                ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
            }
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Statistic");

                    }
                    else
                    {
                        ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "E-posta adresiniz veya şifreniz yanlıştır.");
                return View();
            }
           
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Auth");
        }
        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Error404()
        {
            return View();
        }
    }
}
