using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        var passwordHasher = new PasswordHasher<AppUser>();

        var adminEmail = "admin@example.com";
        var adminUser = new AppUser
        {
            Id = "00000000-0000-0000-0000-0000000ad315",
            UserName = adminEmail,
            NormalizedUserName = adminEmail.ToUpper(),
            Email = adminEmail,
            NormalizedEmail = adminEmail.ToUpper(),
            EmailConfirmed = true,
            ConcurrencyStamp = "ecce3dc6-6fda-4b42-805d-c91ec950af6e",
            SecurityStamp = "a7e9e6d0-2f61-49b9-8240-17d04df7fb61",
            // secretAdminPassword123!!!
            PasswordHash = "AQAAAAEAACcQAAAAEEIvb/VbgsuvrAzJ/6TnEaCv1/Mfr0yVi5R5ki3P6l5cAY1lH9umYDMTeaveAzz+vQ=="
        };

        builder.HasData(new AppUser[]
        {
            adminUser
        });
    }
}
