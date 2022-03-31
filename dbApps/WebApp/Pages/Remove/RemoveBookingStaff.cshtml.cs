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
    public class RemoveBookingStaffModel : PageModel
    {

        public IList<Booking> Bookings {get;set;}

        public int TargetID {get; set;}

        private Cinema db;

        public Booking BookingSearch {get;set;}

        public string message {get;set;}


        public RemoveBookingStaffModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(int ID){
            //set property on page request
            Bookings = db.Bookings.ToList();

            //show all bookings in the database 

            foreach(Booking b in Bookings){
                if(ID > 0 && b.BookingID == ID){
                    BookingSearch = b;
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
        public Booking BookingToDel {get; set;}


        [HttpPost]  
        public IActionResult OnPost()
        {            
            if(SearchID > 0){
                return RedirectToPage("../Remove/RemoveBookingStaff/", new {ID = SearchID});
            }

            if( ((ModelState.IsValid))){
                //delete
                Booking b = db.Bookings.Where(b => b.BookingID == BookingToDel.BookingID).FirstOrDefault();
                db.Bookings.Remove(b);
                db.SaveChanges();
                return RedirectToPage("../Remove/RemoveBookingStaff/", new {ID = -1});

            }

             return RedirectToPage("../Remove/RemoveBookingStaff/");
        }
    }
}