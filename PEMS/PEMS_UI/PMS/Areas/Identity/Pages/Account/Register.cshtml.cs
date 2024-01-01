using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Xml.Linq;

namespace PEMS_UI.Areas.Identity.Pages.Account;
public class RegisterModel : PageModel
{
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public RegisterModel(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [BindProperty]
    public InputModel Input { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            var identity = new IdentityUser { UserName = Input.Email, Email = Input.Email };
            var result = await _userManager.CreateAsync(identity, Input.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(identity, isPersistent: false);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("kamalworld.official@gmail.com", "thpvebvvvusqupsn");
                MailMessage msg = new MailMessage();
                smtp.EnableSsl = true;
                msg.Subject = "Account Credential@DEIMS";
                msg.Body = "Dear User"+ " Your are Successfully register our system. \n Your  ID is: " + Input.Email.Trim() + " and Password is: " + Input.Password.Trim() + ".Don't shere with enyone!" + "\n\n\n Thanks & Regard\n Admin \n PEMS!";
                string toaddress = Input.Email.Trim();
                msg.To.Add(toaddress);
                string fromaddress = "ADMIN@DEIMS<kamalworld.official@gmail.com> ";
                msg.From = new MailAddress(fromaddress);

                smtp.Send(msg);


                return LocalRedirect("~/");
            }
        }

        return Page();
    }
}

