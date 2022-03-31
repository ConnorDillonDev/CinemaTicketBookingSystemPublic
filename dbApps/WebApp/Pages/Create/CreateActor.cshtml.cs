//link to index page - serverside code - runs when requested by client
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
    public class CreateActorModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Actor> Actors {get;set;}

        public string PostResult {get;set;}

        private Cinema db;

        public CreateActorModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            PostResult = ID;
            //set property on page request
            Heading1 = "CreateActor";
            Actors = db.Actors.ToList();
        }

        [BindProperty]
        public Actor Actor { get; set; }

        public IActionResult OnPost()
        {            
            // Ensure Actor name is not left blank, which already should be prevent in the html required tag, regex esnures a blnak name is not submitted
            if( ((ModelState.IsValid) && (Regex.Matches(Actor.ActorName,@"[a-zA-Z]").Count > 0))){
                db.Actors.Add(Actor);
                db.SaveChanges();
                return RedirectToPage ("../Create/CreateActor", new{ID="added"});

            }
            else
            {
                return RedirectToPage ("../Create/CreateActor", new{ID="invalid"});
            }
        }
    }
}