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
    [Authorize(Policy ="MustBelongToStaff")]
    public class RemoveMovie : PageModel
    {

        public IList<Movie> Movies {get;set;}

        public string TargetID {get; set;}

        private Cinema db;

        public Movie MovieSearch {get;set;}

        public string message{get; set;}


        public RemoveMovie(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            //set property on page request
            Movies = db.Movies.ToList();
            //show all bookings in the database 

            foreach(Movie b in Movies){
                if(b.MovieName == ID){
                    MovieSearch = b;
                    TargetID = ID;
                }
            }
            if(ID == "-1") //only set when a booking is removed
            {
                message = "Removed";
            }else if (TargetID != ID && ID !="")
            {
                message = "Not Found!";
            }


        }

        [BindProperty]
        public string SearchID{ get; set;}

        [BindProperty]
        public Movie MovieToDel {get; set;}


        [HttpPost]  
        public IActionResult OnPost()
        {            
            if(SearchID != null){
                return RedirectToPage("../Remove/RemoveMovie/", new {ID = SearchID});
            }
            else
            {
                //delete
                Movie b = db.Movies.Where(b => b.MovieName == MovieToDel.MovieName).FirstOrDefault();
                db.Movies.Remove(b);
                db.SaveChanges();
                return RedirectToPage("../Remove/RemoveMovie/", new {ID = "-1"});

            }
            return RedirectToPage("../Remove/RemoveMovie/");

        }
    }
}