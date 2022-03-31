//link to index page - serverside code - runs when requested by client
using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UWS.CinemaTicketBookingSystem;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using UWS.CinemaTicketBookingSystem;


namespace WebApp.Pages
{
    public class AccountModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Account> Accounts {get;set;}

        private Cinema db;

        public AccountModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "Accounts";
            Accounts = db.Accounts.ToList();
            // Movies = db.Movies.ToList();
            //Accounts = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Accounts = db.Accounts.Select(Account => Account.ComplexName.ToString()); //iterate over instances of Account in the database
        }

        [BindProperty]
        public Account Account { get; set; }

        // public IActionResult OnPost()
        // {
        //     if (ModelState.IsValid)
        //     {
        //         db.Movies.Add(Movie);
        //         db.SaveChanges();
        //         return RedirectToPage("/");
        //     }
        //     return Page();
        // }
    }
}