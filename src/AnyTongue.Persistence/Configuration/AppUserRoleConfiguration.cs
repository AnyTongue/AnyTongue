using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppUserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
{
    public void Configure(EntityTypeBuilder<AppUserRole> builder)
    {
        builder.HasData(new AppUserRole[]
        {
            new() { UserId = "00000000-0000-0000-0000-0000000ad315", RoleId = "01ea419e-4151-48cb-a894-f734e666c7fb" }
        });
    }
}
