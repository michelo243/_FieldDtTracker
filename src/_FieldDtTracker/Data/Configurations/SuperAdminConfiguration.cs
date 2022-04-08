using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using _FieldDtTracker.Extensions;
using _FieldDtTracker.Entities;

namespace _FieldDtTracker.Data.Configurations
{
    public class SuperAdminConfiguration : IEntityTypeConfiguration<FieldDtTrackerUser>
    {
        private const string superAdminId = "198E6AEA-6827-4562-B415-242146DE9B9B";
        public void Configure(EntityTypeBuilder<FieldDtTrackerUser> builder)
        {
            var superAdmin = new FieldDtTrackerUser()
            {
                Id = superAdminId,
                UserName = "superadmin@ner.com",
                NormalizedUserName = "superadmin@ner.com".ToUpper(),
                Email = "superadmin@ner.com",
                NormalizedEmail = "superAdmin@ner.com".ToUpper(),
                PhoneNumber = "0811704141",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                Role = UserRole.SuperAdmin
            };

            superAdmin.PasswordHash = superAdmin.PassGenerate("Admin@265");

            builder.HasData(superAdmin);
        }
    }
}