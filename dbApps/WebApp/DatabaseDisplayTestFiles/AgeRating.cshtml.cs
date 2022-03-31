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
    public class AgeRatingModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<AgeRating> AgeRatings {get;set;}

        private Cinema db;

        public AgeRatingModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "AgeRatings";
            AgeRatings = db.AgeRatings.ToList();
            // Movies = db.Movies.ToList();
            //AgeRatings = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // AgeRatings = db.AgeRatings.Select(AgeRating => AgeRating.ComplexName.ToString()); //iterate over instances of AgeRating in the database
        }

        [BindProperty]
        public AgeRating AgeRating { get; set; }

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