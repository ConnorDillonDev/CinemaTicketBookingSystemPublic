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
    public class ActorModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Actor> Actors {get;set;}

        private Cinema db;

        public ActorModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "Actors";
            Actors = db.Actors.ToList();
            // Movies = db.Movies.ToList();
            //Actors = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Actors = db.Actors.Select(Actor => Actor.ComplexName.ToString()); //iterate over instances of Actor in the database
        }

        [BindProperty]
        public Actor Actor { get; set; }

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