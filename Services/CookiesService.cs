using learning_management_system.Models;

namespace learning_management_system.Services {
  public class CookiesService {
    public static void RegistrationCookies(HttpContext httpContext, string token, UserModel user) {
      var cookieOptions = new CookieOptions {
        HttpOnly = true,
        Secure = true,
        SameSite = SameSiteMode.Strict,
        Expires = DateTime.UtcNow.AddDays(7),
      };
        httpContext.Response.Cookies.Append("AuthToken", token, cookieOptions);
        httpContext.Response.Cookies.Append("Email", user.Email, cookieOptions);
        httpContext.Response.Cookies.Append("FullName", user.FullName, cookieOptions);
        httpContext.Response.Cookies.Append("Points", user.Points.ToString(), cookieOptions);
        httpContext.Response.Cookies.Append("Id", user.Id.ToString(), cookieOptions);
    }
  }
}