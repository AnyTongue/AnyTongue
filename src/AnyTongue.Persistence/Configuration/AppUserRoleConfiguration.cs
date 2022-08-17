using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
    {
        builder.HasData(new IdentityUserRole<int>[]
        {
            new() { UserId = 1, RoleId = 1 }
        });
    }
}
