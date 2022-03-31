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
    public class GenreModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Genre> Genres {get;set;}

        private Cinema db;

        public GenreModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "Genres";
            Genres = db.Genres.ToList();
            // Movies = db.Movies.ToList();
            //Genres = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Genres = db.Genres.Select(Genre => Genre.ComplexName.ToString()); //iterate over instances of Genre in the database
        }

        [BindProperty]
        public Genre Genre { get; set; }

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