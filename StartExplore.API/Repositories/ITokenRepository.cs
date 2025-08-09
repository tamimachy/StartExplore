using Microsoft.AspNetCore.Identity;

namespace StartExplore.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
