using Microsoft.AspNetCore.Identity;

namespace _FieldDtTracker.Entities
{
    public class UserRole
    {
        public const string Guest = "Visitor";
        public const string Admin = "Administrator";
        public const string Staff = "Staff";
        public const string SuperAdmin = "SuperAdmin";
    }

    public class FieldDtTrackerUser:IdentityUser
    {
        public string FullName { get; set; } = null!;
        public string Role { get; set; } = UserRole.Admin;
    }
}
