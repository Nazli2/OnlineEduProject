using Microsoft.AspNetCore.Identity;

namespace OnlineEdu.WebUI.Validators
{
    public class CustomErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir rakam içermelidir."
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Description = "Şire en az bir küçük harf (a-z) ieçermelidir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Description = "Şifre en az bir özel karakter (.,-_*+...) içermelidir."
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Description = $"Şifre en az {length} karakter içermelidir."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Description = "Şire en az bir büyük harf (A-Z) ieçermelidir."
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Description = $"{userName} kullanıcı adıyla zaten bir kayıt mevcut."
            };
        }
    }
}
