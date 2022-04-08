using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _FieldDtTracker.Entities;

namespace _FieldDtTracker.Data.Configurations
{
    public class RoleConfiguration:IEntityTypeConfiguration<IdentityRole>
    {
        private const string superAdminRoleId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string adminId = "7D9B7113-A8F8-4035-99A7-A20DD400F6A3";
        private const string staffId = "78A7570F-3CE5-48BA-9461-80283ED1D94D";
        private const string guestId = "FFE8796D-9AB2-4C5C-9B01-BB58C9F73657";
        
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = superAdminRoleId,
                    Name = UserRole.SuperAdmin,
                    NormalizedName = UserRole.SuperAdmin.ToUpper()
                },
                new IdentityRole
                {
                    Id = adminId,
                    Name = UserRole.Admin,
                    NormalizedName = UserRole.Admin.ToUpper()
                },
                new IdentityRole
                {
                    Id = staffId,
                    Name = UserRole.Staff,
                    NormalizedName = UserRole.Staff.ToUpper()
                },
                new IdentityRole
                {
                    Id = guestId,
                    Name = UserRole.Guest,
                    NormalizedName = UserRole.Guest.ToUpper()
                }
            );
        }
    }
}