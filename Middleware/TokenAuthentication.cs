using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using learning_management_system.Models;

namespace learning_management_system.Middleware {
  public class TokenAuthentication {
    public string GenerateJwtToken(UserModel user){
      var tokenHandler = new JwtSecurityTokenHandler();
      var key = Encoding.ASCII.GetBytes(Environment.GetEnvironmentVariable("JWT_KEY") ?? "default_secret_something_please_work");
      var tokenDescriptor = new SecurityTokenDescriptor{
        Subject = new ClaimsIdentity(new Claim[] {
          new Claim("uid", user.Id.ToString()),
        }),
        Expires = DateTime.UtcNow.AddDays(7),
        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
      };
      var token = tokenHandler.CreateToken(tokenDescriptor);
      return tokenHandler.WriteToken(token);
    }
  }
}