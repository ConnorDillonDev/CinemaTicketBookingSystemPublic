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
    public class RemoveTheatreModel : PageModel
    {

        public IList<Theatre> Theatres {get;set;}

        public int TargetID {get; set;}

        private Cinema db;

        public Theatre TheatreSearch {get;set;}

        public string message {get;set;}


        public RemoveTheatreModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(int ID){
            //set property on page request
            Theatres = db.Theatres.ToList();

            foreach(Theatre s in Theatres){
                if(ID > 0 && s.ScreenNum == ID){
                    TheatreSearch = s;
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
        public Theatre TheatreToDel {get; set;}


        [HttpPost]  
        public IActionResult OnPost()
        {            
            if(SearchID > 0){
                return RedirectToPage("../Remove/RemoveTheatre/", new {ID = SearchID});
            }

            if( ((ModelState.IsValid))){
                //delete
                Theatre s = db.Theatres.Where(s => s.ScreenNum == TheatreToDel.ScreenNum).FirstOrDefault();
                db.Theatres.Remove(s);
                db.SaveChanges();
                return RedirectToPage("../Remove/RemoveTheatre", new {ID = -1});

            }

             return RedirectToPage("../Remove/RemoveTheatre");
        }
    }
}