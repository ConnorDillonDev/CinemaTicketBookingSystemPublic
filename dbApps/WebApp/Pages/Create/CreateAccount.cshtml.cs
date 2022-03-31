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

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace WebApp.Pages
{
    public class CreateAccountModel : PageModel
    {
        public IList<Account> Accounts {get;set;}

        private Cinema db;

        public string Error {get; set;}

        public string Complete {get; set;}

        public CreateAccountModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID) {
            //if ID is set to a value 
            if (ID != null)
            {
                //triggers if the email attempted to be used is already in use
                if (ID == "error")
                {
                    Error = ID;
                }
                //send new account email 
                else if (ID.Contains("@"))
                {
                    Complete = "success";
                }
            }
            //set property on page request
            Accounts = db.Accounts.ToList();
        }

        public void SuccessfullyPosted(string str){
            OnGet(str);
            Page();
        }

        public string HashPassword(string salt, string password)
        {
            //hash the new password 
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(salt + password);
            return passwordHash;
        }

        public string SaltPassword()
        {
            //generate a random salt value to protect password from rainbow table attacks
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [BindProperty]
        public Account Account { get; set; } 

        [BindProperty]
        public string password { get; set; }
        

        public IActionResult OnPost(string password)
        {            
            Account.PasswordSalt = SaltPassword();
            string hashPassword = HashPassword(Account.PasswordSalt, password);
            Account.IsStaff = 0;
            Account.PasswordHash = hashPassword;


            Account.FullName = Account.FirstName + " " + Account.LastName;

            // Ensure Account name is not left blank, which already should be prevent in the html required tag, regex esnures a blnak name is not submitted
            if(((ModelState.IsValid))){
                try{
                    db.Accounts.Add(Account);
                    db.SaveChanges();
                    return RedirectToPage("CreateAccount", new {ID = Account.Email});

                }
                catch(Microsoft.EntityFrameworkCore.DbUpdateException e) //should only be called when the account is attempting to use the same primary key(email)
                {
                     return RedirectToPage("CreateAccount", new {ID = "error"});
                }
            }
            return RedirectToPage("CreateAccount", new {ID = "missing"});

        }
    }
}