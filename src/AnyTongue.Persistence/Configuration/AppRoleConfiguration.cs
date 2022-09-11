using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.HasData(
            new("Admin") { Id = 1, ConcurrencyStamp = "9238d991-0153-4ada-aaf3-57d6040f682e" },
            new("Student") { Id = 2, ConcurrencyStamp = "1f0f17ec-738c-4a37-b7c3-2c32a4f84523" },
            new("ContentAdmin") { Id = 3, ConcurrencyStamp = "e976c27d-45e1-4aca-9954-e42def238b7d" },
            new("ContentCreator") { Id = 4, ConcurrencyStamp = "08b8184c-1af1-40ad-a3bb-94524095caaa" }
            );
    }
}
