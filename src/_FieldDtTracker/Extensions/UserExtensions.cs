using Microsoft.AspNetCore.Identity;
using _FieldDtTracker.Entities;

namespace _FieldDtTracker.Extensions
{
    public static partial class UserExtensions
    {
        public static string? PassGenerate(this FieldDtTrackerUser user, string password)
        {
            if (password is { Length: < 5 })
                return null;
            var passHash = new PasswordHasher<FieldDtTrackerUser>();
            return passHash.HashPassword(user, password);
        }
    }
}