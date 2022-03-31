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

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Pages
{
    [Authorize(Policy ="MustBelongToStaff")]
    public class CreateDirectorModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Director> Directors {get;set;}

        public string PostResult {get;set;}


        private Cinema db;

        public CreateDirectorModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            PostResult = ID;
            //set property on page request
            Heading1 = "CreateDirector";
            Directors = db.Directors.ToList();
        }


        [BindProperty]
        public Director Director { get; set; }

        public IActionResult OnPost()
        {            
            // Ensure Director name is not left blank, which already should be prevent in the html required tag, regex esnures a blnak name is not submitted
            if( ((ModelState.IsValid) && (Regex.Matches(Director.DirectorName,@"[a-zA-Z]").Count > 0))){
                db.Directors.Add(Director);
                db.SaveChanges();
                return RedirectToPage ("../Create/CreateDirector", new {ID = "added"});
            }
            else
            {
                return RedirectToPage ("../Create/CreateDirector", new {ID = "invalid"});
            }
        }
    }
}