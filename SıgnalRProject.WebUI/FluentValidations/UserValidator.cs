using FluentValidation;
using SıgnalRProject.Entity.Entities;
using SıgnalRProject.WebUI.DTOs.UserDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.WebUI.FluentValidations
{
	public class UserValidator : AbstractValidator<AppUser>
	{
		public UserValidator()
		{
			RuleFor(x => x.Name)
			 .NotEmpty()
			 .MinimumLength(3)
			 .MaximumLength(50)
			 .WithName("İsim");

			RuleFor(x => x.Surname)
			 .NotEmpty()
			 .MinimumLength(3)
			 .MaximumLength(50)
			 .WithName("Soyisim");

			RuleFor(x => x.PhoneNumber)
			 .NotEmpty()
			 .MinimumLength(11)
			 .WithName("Telefon numarası");

		}
		public class RegisterUserValidator : AbstractValidator<RegisterDto>
		{
			public RegisterUserValidator()
			{
				RuleFor(x => x.Name)
			 .NotEmpty()
			 .MinimumLength(3)
			 .MaximumLength(50)
			 .WithName("İsim");

				RuleFor(x => x.Surname)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(50)
				 .WithName("Soyisim");

				RuleFor(x => x.Mail)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(100)
				 .WithName("Email");

				RuleFor(x => x.Password)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(100)
				 .WithName("Parola");

				RuleFor(x => x.ConfirmPassword)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(100)
				 .WithName("Parola");


			}

		}

		public class LoginUserValidator : AbstractValidator<UserLoginDto>
		{
			public LoginUserValidator()
			{


				RuleFor(x => x.Email)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(100)
				 .WithName("Email");

				RuleFor(x => x.Password)
				 .NotEmpty()
				 .MinimumLength(3)
				 .MaximumLength(100)
				 .WithName("Parola");

			}

		}
	}
}
