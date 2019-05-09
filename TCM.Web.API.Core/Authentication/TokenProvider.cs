using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(string userId, string url, string secret, List<string> roleList);
        Tuple<bool, ClaimsPrincipal> ValidateToken(string token);
    }
    public class TokenProvider : ITokenProvider
    {

        public string CreateToken(string userId, string url, string secret, List<string> roleList)
        {

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userId.ToString())
            };

            if (roleList != null)
            {
                for(int i=0; i< roleList.Count; i++)
                {
                    claims.Add(new Claim(ClaimTypes.Role, roleList[i]));
                }
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                //Issuer = url,
                //Audience = url,
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }


        public Tuple<bool, ClaimsPrincipal> ValidateToken(string token)
        {
            throw new NotImplementedException();
        }
    }
}
