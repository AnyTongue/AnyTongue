using Microsoft.AspNetCore.Identity;

namespace AnyTongue.Domain.Models;

public class AppUser : IdentityUser
{
    public AppUser()
    {
        SecurityStamp = Guid.NewGuid().ToString();
    }
}
