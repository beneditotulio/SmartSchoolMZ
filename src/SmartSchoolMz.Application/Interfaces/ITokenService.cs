using Microsoft.AspNetCore.Identity;

namespace SmartSchoolMz.Application.Interfaces;

public interface ITokenService
{
    string CreateToken(IdentityUser user, IEnumerable<string> roles);
}
