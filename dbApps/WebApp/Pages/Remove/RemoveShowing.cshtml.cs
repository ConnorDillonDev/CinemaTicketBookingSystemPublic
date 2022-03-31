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
    public class RemoveShowingModel : PageModel
    {

        public IList<Showing> Showings {get;set;}

        public int TargetID {get; set;}

        private Cinema db;

        public Showing ShowingSearch {get;set;}

        public string message {get;set;}


        public RemoveShowingModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(int ID){
            //set property on page request
            Showings = db.Showings.ToList();

            foreach(Showing s in Showings){
                if(ID > 0 && s.ShowingID == ID){
                    ShowingSearch = s;
                    TargetID = ID;
                }
            }
            if(TargetID == 0 && ID > 0)//true if not found in database
            {
                message = "Not Found!";
            }
            if(ID == -1) //only set when a booking is removed
            {
                message = "Removed";
            }
        }

        [BindProperty]
        public int SearchID{ get; set;}

        [BindProperty]
        public Showing ShowingToDel {get; set;}


        [HttpPost]  
        public IActionResult OnPost()
        {            
            if(SearchID > 0){
                return RedirectToPage("../Remove/RemoveShowing/", new {ID = SearchID});
            }

            if( ((ModelState.IsValid))){
                //delete
                Showing s = db.Showings.Where(s => s.ShowingID == ShowingToDel.ShowingID).FirstOrDefault();
                db.Showings.Remove(s);
                db.SaveChanges();
                return RedirectToPage("../Remove/RemoveShowing", new {ID = -1});

            }

             return RedirectToPage("../Remove/RemoveShowing");
        }
    }
}