using Core.Entities.Concrete;
using Core.Extensions;
using Core.Utilities.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }        // IConfiguration appsettings'deki değerleri okumaya yarıyor
        private TokenOptions _tokenOptions;                 // appsettings'den okunan değerler tokenoptions'a atanır. TokenOptions bir helper class
        private DateTime _accessTokenExpiration;            // DateTime ile accesstoken ne zaman geçersizleşecek onu belirliyoruz
        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;                                                      // configuration injection
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();       // appsettings'deki "TokenOptions" section'ını al ve TokenOptions sınıfını kullanarak map'le
                                                                                                // yani Audience-->Audience, Issuer-->Issuer...
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)                     // "user bilgisini ve claimleri ver ona göre token oluşturayım"
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);          // appsettings'te yazdığımız 10dk bekleme süresini çağırdık. yani şimtiye 10dk ekle ve token'ı sonlandır
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);               // kendi yazdığımız SecurityKey class'ı ile appsettings'deki SecurityKey'i kullanarak securityKey oluştur. Artık elimizde bu token'ı oluşturacak güvevlik anahtarı da var
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);        // kendi yazdığımız SigningCredentialsHelper ile hangi algoritmayı hangi anahtarı kullanacağını söylüyoruz
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };

        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(         //JwtSecurityToken oluşturma
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)       // claim oluşturma
        {
            var claims = new List<Claim>();                                     // Claims kütüphanesinde kullandığımız metotlar yok. Var olan bu nesneye yeni metotlar ekleyebiliyoruz. Buna Extension deniyor. Yani kendi Extensions'ımızı yazacağız
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
