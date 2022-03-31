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
    public class TheatreModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Theatre> Theatres {get;set;}

        private Cinema db;

        public TheatreModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "Theatres";
            Theatres = db.Theatres.ToList();
            // Movies = db.Movies.ToList();
            //Theatres = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Theatres = db.Theatres.Select(Theatre => Theatre.ComplexName.ToString()); //iterate over instances of Theatre in the database
        }

        [BindProperty]
        public Theatre Theatre { get; set; }

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