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
using Microsoft.AspNetCore.Authorization;



namespace WebApp.Pages
{
    //restrict to superuser
    [Authorize(Policy ="MustBelongToSuperUser")]

    public class AccountManagementModel : PageModel
    {
        public IList<Account> Accounts {get;set;}

        public Account AccountFound {get;set;}

        public bool NotFound {get;set;}

        public string message {get;set;}

        private Cinema db;

        public AccountManagementModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            //set property on page request
            Accounts = db.Accounts.ToList();
            if(ID == "NotFound")
            {
                NotFound = true;
            }
            else if (ID == "updated")
            {
                message = "Account Updated!";
            }

            //comapte accounts Emails to the ID that has been passed which should also be an email
            foreach(Account s in Accounts){
                if(s.Email == ID){
                    // if account found set to global varliable 
                    AccountFound = s;
                }
            }
        }


        [BindProperty]
        public Account Account { get; set; }

        
        [BindProperty]
        public string AccountEmail { get; set; }

        [BindProperty]
        public string route { get; set; }
        
        
        [BindProperty]
        public Account UpdateAccount { get; set; }


        public IActionResult OnPost()
        {            
              if(AccountEmail != null && route is null){
                  //if post was a search request

                Account account = db.Accounts.FirstOrDefault(a => a.Email == AccountEmail);

                if(account == null)
                {
                    return RedirectToPage("../AccountManagement/AccountManagement/", new {ID = "NotFound"});
                }
                else
                {
                    return RedirectToPage("../AccountManagement/AccountManagement/", new {ID = AccountEmail});
                }
                
            }

            //if post was a update account details request
            if (route=="update")
            {
                //find first matching in the database
                Account account = db.Accounts.FirstOrDefault(a => a.Email == UpdateAccount.Email);
                account.Username = UpdateAccount.Username;
                account.FirstName = UpdateAccount.FirstName;
                account.LastName = UpdateAccount.LastName;
                account.FullName = UpdateAccount.FullName;
                account.IsStaff = UpdateAccount.IsStaff;

                // pass password through the bcrypt function
                string updatepasswordHash = BCrypt.Net.BCrypt.HashPassword(account.PasswordSalt + UpdateAccount.PasswordHash);
                account.PasswordHash = updatepasswordHash;
 
                //save account update
                db.Accounts.Update(account);
                db.SaveChanges();
                return RedirectToPage("../AccountManagement/AccountManagement/", new {ID = "updated"});

            }
            
            return RedirectToPage("../AccountManagement/AccountManagement/");

        }
    }
}