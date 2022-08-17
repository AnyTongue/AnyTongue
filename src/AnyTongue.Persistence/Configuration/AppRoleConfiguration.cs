using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.HasData(
            new("Admin") { Id = 1 },
            new("Student") { Id = 2 },
            new("ContentAdmin") { Id = 3 },
            new("ContentCreator") { Id = 4 }
            );
    }
}
