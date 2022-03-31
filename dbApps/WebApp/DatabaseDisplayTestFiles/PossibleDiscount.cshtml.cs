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
    public class PossibleDiscountModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<PossibleDiscount> PossibleDiscounts {get;set;}

        private Cinema db;

        public PossibleDiscountModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "PossibleDiscounts";
            PossibleDiscounts = db.PossibleDiscounts.ToList();
            // Movies = db.Movies.ToList();
            //PossibleDiscounts = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // PossibleDiscounts = db.PossibleDiscounts.Select(PossibleDiscount => PossibleDiscount.ComplexName.ToString()); //iterate over instances of PossibleDiscount in the database
        }

        [BindProperty]
        public PossibleDiscount PossibleDiscount { get; set; }

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