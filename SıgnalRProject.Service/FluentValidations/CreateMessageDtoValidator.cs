using FluentValidation;
using SıgnalRProject.Dto.MessageDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Service.FluentValidations
{
	public class CreateMessageDtoValidator : AbstractValidator<CreateMessageDto>
	{
		public CreateMessageDtoValidator()
		{
			RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad ve soyad alanı boş bırakılamaz.");
			RuleFor(x => x.Mail).NotEmpty().EmailAddress().WithMessage("Geçerli bir mail adresi giriniz.");
			RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon numarası boş bırakılamaz.");
			RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz.");
			RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj içeriği boş bırakılamaz.");
		}
	}

}
