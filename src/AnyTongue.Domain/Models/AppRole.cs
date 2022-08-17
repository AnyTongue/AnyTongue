using Microsoft.AspNetCore.Identity;

namespace AnyTongue.Domain.Models;

public class AppRole : IdentityRole<int>
{
    public AppRole() { }

    public AppRole(string name) : base(name)
    {
        NormalizedName = name.ToUpper();
    }
}
