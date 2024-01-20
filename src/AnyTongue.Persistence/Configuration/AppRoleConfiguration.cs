using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyTongue.Persistence.Configuration;

public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
{
    public void Configure(EntityTypeBuilder<AppRole> builder)
    {
        builder.HasData(
            new("Admin") { Id = "01ea419e-4151-48cb-a894-f734e666c7fb", ConcurrencyStamp = "9238d991-0153-4ada-aaf3-57d6040f682e" },
            new("Student") { Id = "2242b904-a0ae-4588-9ce8-f2fad4240fb8", ConcurrencyStamp = "1f0f17ec-738c-4a37-b7c3-2c32a4f84523" },
            new("ContentAdmin") { Id = "19ebecc2-43b4-406b-9357-2ea28a5512f3", ConcurrencyStamp = "e976c27d-45e1-4aca-9954-e42def238b7d" },
            new("ContentCreator") { Id = "e317f55c-8237-435d-9796-68369cb12e1d", ConcurrencyStamp = "08b8184c-1af1-40ad-a3bb-94524095caaa" }
            );
    }
}
