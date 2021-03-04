using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Core.Extensions
{       // bir kişinin jwt'den gelen claimlerini okumak için ClaimsPrincipal classını kullanıyoruz. "Claim kütüphanesinde"
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
