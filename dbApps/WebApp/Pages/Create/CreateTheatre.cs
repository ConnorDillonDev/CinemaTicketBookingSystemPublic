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

    public class CreateTheatreModel : PageModel
    {

        public IList<Theatre> Theatres {get;set;}

        public IList<Building> Buildings {get;set;}

        public string PostResult {get;set;}

        private Cinema db;

        public CreateTheatreModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            PostResult = ID;
            //set property on page request
            Theatres = db.Theatres.ToList();
            Buildings = db.Buildings.ToList();
        }


        [BindProperty]
        public Theatre Theatre { get; set; }

        public IActionResult OnPost()
        {            
            Theatres = db.Theatres.ToList();

            // Ensure Theatre name is not left blank, which already should be prevent in the html required tag, regex esnures a blnak name is not submitted
            if(ModelState.IsValid){
                foreach(Theatre t in Theatres)
                {
                    if (Theatre.ScreenNum == t.ScreenNum) //This will ensure unique key is not voilated (attempted dup)
                    {
                        return RedirectToPage ("../Create/CreateTheatre", new {ID = "dup"});
                    }
                }
                db.Theatres.Add(Theatre);
                db.SaveChanges();
                return RedirectToPage ("../Create/CreateTheatre", new {ID = "added"});
            }
            else
            {
                return RedirectToPage ("../Create/CreateTheatre", new {ID = "invalid"});
            }
        }
    }
}