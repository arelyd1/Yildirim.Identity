using Microsoft.AspNetCore.Identity;

namespace Yildirim.Identity.CustomDescriber
{
    public class CustomErrorDesciriber :IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new()
            {
                Code = " PasswordTooShort",
                Description = $"Parola en az {length} karakter olabilir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description="Parola en az alfanümerik(~! vs.)karakter içermelidir. "
            };
        }
        public override IdentityError DuplicateUserName(string userName)
        {
            return new()
            {
                Code = "DuplicateUserName",
                Description = $"{userName} zaten alınmış "
            };
        }
    }
}
