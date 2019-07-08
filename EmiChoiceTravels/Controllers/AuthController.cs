using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace EmiChoiceTravels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("token")]
        public IActionResult GetToken(string email)
        {
            //get key
            string key = Startup.Configuration[AppConstant.Secret];
            //get symmetric key
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            //get signin credentials
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            //get claims
            List<Claim> claims = new List<Claim>();
            bool isAdmin = email.Equals(AppConstant.UserEmail, StringComparison.InvariantCultureIgnoreCase);
            if (isAdmin)
            {
                claims.Add(new Claim(ClaimTypes.Role, "Administrator"));
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.Role, "User"));
            }
            //create web token
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: Startup.Configuration[AppConstant.Issuer],
                audience: Startup.Configuration[AppConstant.Audience],
                signingCredentials: signingCredentials,
                expires: isAdmin ? DateTime.Now.AddHours(8): DateTime.Now.AddHours(1),
                claims: claims
                );
            //return a writable token
            return Ok(new JwtSecurityTokenHandler().WriteToken(token));
        }
    }
}