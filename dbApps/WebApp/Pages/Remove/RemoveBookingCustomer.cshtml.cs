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
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;


using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using QRCoder;



namespace WebApp.Pages
{
    [Authorize(Policy ="MustBelongToCustomer")]
    public class RemoveBookingCustomerModel : PageModel
    {

        public IList<Booking> Bookings {get;set;}
        public IList<Showing> Showings {get;set;}
        public IList<Bitmap> qrCodeList {get;set;}
        
        private Cinema db;

        public Booking BookingSearch {get;set;}

        public string Email{get;set;}

        public bool BookingConfirmed {get;set;}
        public bool BookingRemoved {get;set;}

        public RemoveBookingCustomerModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(string ID){
            //set property on page request
            Bookings = db.Bookings.ToList();
            Showings = db.Showings.ToList();
            GetAccount();
            if(ID == "confirmed")
            {
                BookingConfirmed = true;
            }
            if(ID == "Removed")
            {
                BookingRemoved = true;
            }
            

        }

        public void GetAccount()
        {
            
            //find email from claimsPrincipal
            var identity = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            foreach (Claim c  in claims)
            {
                string str = c.ToString();
                if(c.ToString().Contains("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")){
                    string result = str.Substring(str.LastIndexOf(':') + 1); //extract the email
                    result = result.Trim();
                    Email = result;
                }
            }
        }

        [BindProperty]
        public int BookingIDToDel {get; set;}


        [HttpPost]  
        public IActionResult OnPost()
        {            

            if(BookingIDToDel != null){
                // find the match in the database 
                Booking b = db.Bookings.Where(b => b.BookingID == BookingIDToDel).FirstOrDefault();
                //remove the booking from the database
                db.Bookings.Remove(b);
                db.SaveChanges();
            }

             return RedirectToPage("../Remove/RemoveBookingCustomer", new{ID = "Removed"});
        }
    }
}