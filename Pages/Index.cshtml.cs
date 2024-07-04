using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using learning_management_system.Data;
using Microsoft.EntityFrameworkCore;
using learning_management_system.Middleware;
using learning_management_system.Services;

namespace learning_management_system.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly ApplicationDbContext _context;
    private readonly PasswordHasher<IndexModel> _passwordHasher = new PasswordHasher<IndexModel>();

    [BindProperty]
    public string? Email { get; set; }
    [BindProperty]
    public string? Password { get; set; }
    public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public void OnGet()
    {

    }
    public async Task<IActionResult> OnPostAsync() {
        if(!ModelState.IsValid) {
            return Page();
        }
        var validEmail = Email.Trim().ToLower();
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == validEmail);
        if (user == null) {
            ModelState.AddModelError("Email", "Email does not exist");
            return Page();
        }
        var comparePassword = _passwordHasher.VerifyHashedPassword(this, user.PasswordHash, Password);
        if (comparePassword == PasswordVerificationResult.Failed) {
            ModelState.AddModelError("Password", "Incorrect Password");
            return Page();
        }
        var token = new TokenAuthentication().GenerateJwtToken(user);
        CookiesService.RegistrationCookies(HttpContext, token, user);
        _logger.LogInformation("Successful Login!");
        return RedirectToPage("/home");
    }
}
