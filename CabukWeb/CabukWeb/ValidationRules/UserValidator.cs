using CabukWeb.Models;
using FluentValidation;

namespace CabukWeb.ValidationRules
{
	public class UserValidator:AbstractValidator<Users>
	{
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-posta Boş Geçilemez");
            RuleFor(x => x.Email).EmailAddress().WithMessage("E-posta doğru şekilde olmalıdır");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Boş Geçilez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen En Az 2 Karakter Girişi Yapınız");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Lütfen En Fazla 50 Karakterlik Girişi Yapınız");
        }
    }
}
