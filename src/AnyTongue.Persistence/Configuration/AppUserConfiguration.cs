using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        var passwordHasher = new PasswordHasher<AppUser>();

        var adminEmail = "admin@example.com";
        var adminUser = new AppUser()
        {
            Id = 1,
            UserName = adminEmail,
            NormalizedUserName = adminEmail.ToUpper(),
            Email = adminEmail,
            NormalizedEmail = adminEmail.ToUpper(),
            EmailConfirmed = true,
            ConcurrencyStamp = Guid.NewGuid().ToString(),
            SecurityStamp = Guid.NewGuid().ToString()
        };

        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "secretAdminPassword123!!!");

        builder.HasData(new AppUser[]
        {
            adminUser
        });
    }
}
