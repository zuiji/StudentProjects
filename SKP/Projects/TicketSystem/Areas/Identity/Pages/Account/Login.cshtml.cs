using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TicketSystem.Areas.Identity.Data;

namespace TicketSystem.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, ILogger<LoginModel> logger)
        {
            _signInManager = signInManager;
			_userManager = userManager;
            _logger = logger;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Husk mig?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");

            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var signinResult = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);

				// Load user to check for sigin errors...
				var user = await _userManager.FindByEmailAsync(Input.Email);


				// If login not succeeded...
				if (!signinResult.Succeeded)
				{
					if (signinResult.IsNotAllowed)
					{
						if (!await _userManager.IsEmailConfirmedAsync(user))
						{
							// Email isn't confirmed.
							ModelState.AddModelError(string.Empty, "Du har ikke verificeret din email endnu!");
							return Page();
						}

						if (!await _userManager.IsPhoneNumberConfirmedAsync(user))
						{
							// Phone Number isn't confirmed.
							ModelState.AddModelError(string.Empty, "Du har ikke verificeret dit telefon nummer!");
							return Page();
						}
					}
					else if (signinResult.IsLockedOut)
					{
						// Account is locked out.
						ModelState.AddModelError(string.Empty, "Din konto er deaktiveret! Kontakt en system administrator...");
						return Page();
					}
					else if (signinResult.RequiresTwoFactor)
					{
						// 2FA required.
						ModelState.AddModelError(string.Empty, "To-Faktor godkendelse er krævet for denne konto!");
						return Page();
					}
					else
					{
						// Username or password is incorrect.
						if (user == null)
						{
							// Username is incorrect.
							ModelState.AddModelError(string.Empty, "Det indtastede brugernavn eller password er forkert!");
							return Page();
						}
						else
						{
							// Password is incorrect.
							ModelState.AddModelError(string.Empty, "Det indtastede brugernavn eller password er forkert!");
							return Page();
						}
					}
				}


				// If login succeeded...
				if (signinResult.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect(returnUrl);
                }
                if (signinResult.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, Input.RememberMe });
                }
                if (signinResult.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Brugeren blev ikke logget ind!");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
