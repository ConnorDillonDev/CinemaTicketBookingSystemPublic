using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

using UWS.CinemaTicketBookingSystem;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace WebApp.Pages
{
    //staff cookie claim 
    [Authorize(Policy ="MustBelongToStaff")]
    public class CreateShowingModel : PageModel
    {
        public IQueryable<Showing> Showings {get;set;}
        
        public IList<Theatre> Theatres {get;set;}

        public IList<Movie> Movies {get;set;}

        public string Message {get;set;}

        private Cinema db;

        public CreateShowingModel(Cinema injectedContext)
        {   
            db = injectedContext;

        }   

        public void OnGet(string ID){

            Message = ID;
            //prep data on page get
            Showings = db.Showings;
            Movies = db.Movies.ToList();
            Theatres = db.Theatres.ToList();
        }


        [BindProperty]
        //attributes set in the .cshtml using the asp-for
        public Showing showing { get; set; }


        public IActionResult OnPost()
        {   
            if (ModelState.IsValid){ 
                //add new showing from the webpage 
                db.Showings.Add(showing);
                db.SaveChanges();
                return RedirectToPage("../Create/CreateShowing", new {ID="success"});
            }
            return RedirectToPage("../Create/CreateShowing", new{ID = "invalid"}); // can only be triggered using custom POST or wrong model (date)

        }

    }
}