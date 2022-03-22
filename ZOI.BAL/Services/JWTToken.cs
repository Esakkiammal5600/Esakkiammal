using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZOI.BAL.Services.Interface;

namespace ZOI.BAL.Services
{
    public class JWTToken : IJWTToken
    {
        private readonly IConfiguration _configuration;

        public JWTToken(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetJWTToken(string emailId, IConfiguration config)
        {
            return BuildToken(emailId, config);
        }

        private string BuildToken(string email, IConfiguration _config)
        {
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddMinutes(720),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
