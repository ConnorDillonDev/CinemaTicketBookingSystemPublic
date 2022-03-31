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
    public class MovieModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Movie> Movies {get;set;}

        private Cinema db;

        public MovieModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "CreateMovie";
            Movies = db.Movies.ToList();
            // Movies = db.Movies.ToList();
            //Buildings = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Buildings = db.Buildings.Select(building => building.ComplexName.ToString()); //iterate over instances of building in the database
        }

        [BindProperty]
        public Movie Movie { get; set; }

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