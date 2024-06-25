using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using learning_management_system.Data;
using learning_management_system.Models;
using Microsoft.EntityFrameworkCore;

namespace learning_management_system.Pages;

public class RegistrationModel : PageModel
{
    private readonly ILogger<RegistrationModel> _logger;
    private readonly ApplicationDbContext _context;
    private readonly PasswordHasher <RegistrationModel> _passwordHasher = new PasswordHasher<RegistrationModel>();
    
    [BindProperty]
    public string? Email { get; set; }
    [BindProperty]
    public string? Password { get; set; }
    [BindProperty]
    public string? FullName { get; set; }

    public RegistrationModel(ILogger<RegistrationModel> logger, ApplicationDbContext context)
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
        var trimmedPassword = Password.Trim();
        var trimmedFullName = FullName.Trim();
        var hashedPassword = _passwordHasher.HashPassword(this, trimmedPassword);
        bool emailExists = await _context.Users.AnyAsync(u => u.Email == validEmail);
        if (emailExists) {
            ModelState.AddModelError("Email", "Email already exists");
            return Page();
        }
        var user = new UserModel {
            Email = validEmail,
            PasswordHash = hashedPassword,
            FullName = trimmedFullName,
            Points = 0
        };
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        _logger.LogInformation("Successful Registration!");
        return RedirectToPage("/home");
    }
}
