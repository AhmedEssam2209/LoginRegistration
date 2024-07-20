using LoginRegistration.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginRegistration.Pages
{
	public class RegisterModel : PageModel
	{
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;

		[BindProperty]
		public Register Model { get; set; }

		public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		public void OnGet()
		{
		}


		public async Task<IActionResult> OnPostAsync()
		{
			if (ModelState.IsValid)
			{
				var user = new IdentityUser()
				{

					UserName = Model.Username,
					Email = Model.Email,
					PhoneNumber = Model.PhoneNumber

				};
				var result = await userManager.CreateAsync(user, Model.Password);
				if (result.Succeeded)
				{
					await signInManager.SignInAsync(user, false);
					return RedirectToPage("Index");
				}
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError("", error.Description);

				}
			}
			return Page();

		}
	}
}


