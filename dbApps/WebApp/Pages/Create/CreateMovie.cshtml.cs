using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using UWS.CinemaTicketBookingSystem;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages
{
    [Authorize(Policy ="MustBelongToStaff")]
    public class CreateMovieModel : PageModel
    {
        public IQueryable<Movie> Movies {get;set;}
        public IQueryable<Genre> Genres {get;set;}
        public IQueryable<AgeRating> AgeRatings {get;set;}
        public IQueryable<Director> Directors {get;set;}
        public IQueryable<Actor> Actors {get;set;}

        public IQueryable<DirectorsMovieJunction> DirectorsMovieJunctions {get;set;}
        public IQueryable<ActorsMovieJunction> ActorsMovieJunctions {get;set;}
        

        public IList<Genre> GenresList {get;set;}
        public IList<AgeRating> AgeRatingsList {get;set;}

        //sep tables
        public IList<Director> DirectorsList {get;set;}
        public IList<Actor> ActorsList {get;set;}

        public bool SuccessfullyAdded {get;set;} 

        public string message {get;set;}

        private Cinema db;

        public CreateMovieModel(Cinema injectedContext)
        {   
            db = injectedContext;

        }   

        public void OnGet(string ID){

            if(ID == "Added")
            {
                SuccessfullyAdded = true;
            }
            else if (ID == "error")
            {
                message = "error";
            }
            else if (ID == "Invalid")
            {
                message = "Invalid";
            }
            Movies = db.Movies;
            Genres = db.Genres;
            AgeRatings = db.AgeRatings;
            Directors = db.Directors;

            Actors = db.Actors;

            DirectorsMovieJunctions = db.DirectorsMovieJunctions;
            ActorsMovieJunctions = db.ActorsMovieJunctions;

            GenresList = db.Genres.ToList();
            AgeRatingsList = db.AgeRatings.ToList();

            //sep tables
            DirectorsList = db.Directors.ToList();
            ActorsList = db.Actors.ToList();

        }

        [BindProperty]
        public Movie Movie { get; set; }
        
        
        [BindProperty]
        public DirectorsMovieJunction DirectorMovieJunction { get; set; }

        [BindProperty]
        public ActorsMovieJunction ActorMovieJunction { get; set; }



        public IActionResult OnPost()
        {   

            if (ModelState.IsValid){ 
                try{
                    //add a entry to our jucntion table
                    db.ActorsMovieJunctions.Add(ActorMovieJunction);
                    //add entry to direcotrmovie juncition table
                    db.DirectorsMovieJunctions.Add(DirectorMovieJunction);
                    //add new movie to the database 
                    db.Movies.Add(Movie);
                    db.SaveChanges();
                    return RedirectToPage("../Create/CreateMovie", new {ID = "Added"});
                }
                catch(Microsoft.EntityFrameworkCore.DbUpdateException e)
                {
                    return RedirectToPage("../Create/CreateMovie", new {ID = "error"}); //should trigger if PK is reused.(MovieName)
                }

            }
            else{ // this section should never trigger. Unless forced using custom post requests
                var errors = ModelState.Select(x => x.Value.Errors)
                    .Where(y=>y.Count>0)
                    .ToList();
                return RedirectToPage("../Create/CreateMovie", new {ID = "Invalid"});

            }
            
        }

    }
}