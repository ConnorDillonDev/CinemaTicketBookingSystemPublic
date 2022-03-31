//link to index page - serverside code - runs when requested by client
using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UWS.CinemaTicketBookingSystem;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using UWS.CinemaTicketBookingSystem;
using System.Text.RegularExpressions;
using System.Security.Claims;
using System.Web;
using Microsoft.AspNetCore.Authentication;

namespace WebApp.Pages
{
    public class LoginModel : PageModel
    {
        private Cinema db;

        public Account AccountFound;


        public IList<Account> Accounts {get;set;}
        
        public LoginModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Accounts = db.Accounts.ToList();
        }

        public void SuccessfullyPosted(){
            OnGet();
            Page();
        }

        //verify the users password 
        public bool verifyCred(string password){
            string passwordHash; 
            string salt; 
            bool verified = false;
            Accounts = db.Accounts.ToList();
            foreach (Account a in Accounts)
            {
                if(a.Email == Email)
                {
                    passwordHash = a.PasswordHash;
                    salt = a.PasswordSalt;

                    //use verify bcrypt function to ensure that the hashed values match 
                    verified = BCrypt.Net.BCrypt.Verify(salt + Password, passwordHash);

                    if(verified){
                        AccountFound = a;
                        Console.WriteLine(a);
                    }
                    break;
                }
            }
            return verified;
        }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public bool RememberMe { get; set; }

        [ValidateAntiForgeryToken]  

        public async Task<IActionResult> OnPostAsync()
        {   
            //set cookie claims and states which are used for page policies

            string customer = "FALSE";
            string staff = "FALSE";
            string SU = "FALSE";

            bool verified = verifyCred(Password);      
 
            // assign claims based on the type of account that was verifies in the database 
            if (verified){
                if (AccountFound.Email == "SuperUser996@cinema.com"){
                    staff = "TRUE";
                    customer = "TRUE";
                    SU = "TRUE";
                }
                else if(AccountFound.IsStaff == 1)
                {
                    staff = "TRUE";
                    customer = "TRUE";
                }
                else
                {
                    customer = "TRUE"; 
                }
                var claims = new List<Claim>{
                    new Claim("IsCustomer", customer),
                    new Claim("IsStaff", staff),
                    new Claim("IsSuperUser", SU),
                    new Claim(ClaimTypes.Name, AccountFound.FullName),
                    new Claim(ClaimTypes.Email, AccountFound.Email),
                };
                

                var identity = new ClaimsIdentity(claims, "MyCookieAuth");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                var authProp = new AuthenticationProperties
                {
                    //set cookies to not expire when remeber me is ticked
                    IsPersistent = RememberMe
                };

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal, authProp); //send the cookie to the user client
                return RedirectToPage("/Index");
            }
            else
            {
                Console.WriteLine("Failed to login");
                return RedirectToPage("/AccessDenied/AccessDenied");
            }
            // SuccessfullyPosted();
        }

    }
}