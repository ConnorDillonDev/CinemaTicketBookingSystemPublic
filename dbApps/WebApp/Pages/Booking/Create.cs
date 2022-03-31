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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;


namespace WebApp.Pages
{
    //must have the customer claim to acccess 
    [Authorize(Policy ="MustBelongToCustomer")]

    public class Create : PageModel
    {
        public string Heading1 {get;set;}

        public IQueryable<Booking> Bookings {get;set;}

        //Movies for the ticket price
        public IList<Movie> Movies {get;set;}
        public IList<Showing> Showings {get;set;}
        public IList<AgeRating> AgeRatings {get;set;}

        private Cinema db;

        public Movie Movie {get;set;}

        //all the attributes which realte to a creating a movie
        public decimal AdultPrice {get;set;}
        public decimal ChildPrice {get;set;}
        public string MovieFound {get;set;}
        public string Date {get;set;}
        public float Time {get;set;}
        
        public int ShowingID {get;set;}
        public string Email {get;set;}

        public bool hideKidTickets {get;set;}

        


        public Create(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(int ID){
            hideKidTickets = false;
            //set property on page request
            Bookings = db.Bookings;
            Movies = db.Movies.ToList();
            Showings = db.Showings.ToList();
            AgeRatings = db.AgeRatings.ToList();

            // check cookie claims assigned at signing in success
            var identity = (ClaimsIdentity)User.Identity;
            IEnumerable<Claim> claims = identity.Claims;

            //the following extracts a customer login email
            foreach (Claim c  in claims)
            {
                string str = c.ToString();
                if(c.ToString().Contains("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")){
                    string result = str.Substring(str.LastIndexOf(':') + 1);
                    result = result.Trim();
                    Email = result;
                }
            }

            if(ID != null)
            {
                ShowingID = ID;
                //search for showing with the ID passed to the onget method
                foreach (Showing s in Showings)
                {
                    if(ID == s.ShowingID){
                        Time = s.StartTime;
                        Date = s.Day;
                        MovieFound = s.MovieName;

                        foreach (Movie m in Movies)
                        {
                            if(m.MovieName == MovieFound)
                            {
                                Movie = m;
                                ChildPrice = m.ChildPrice;
                                AdultPrice = m.AdultPrice;

                                 foreach(AgeRating a in AgeRatings)
                                {
                                    if(Movie.RatingID == a.RatingID)
                                    {
                                        string checkAge = a.Age.ToString();
                                        hideKidTickets = checkAge.Contains("18") | checkAge.Contains("15");      //hide chidren tickets if the age is >15                 
                                    }
                                }
                            }
                        }
                        break;
                    }
                }
            } 
        }

        [BindProperty]
        public Booking Booking { get; set; }

        [BindProperty]
        public string GoBack { get; set; }

        public IActionResult OnPost()
        {         
            Console.WriteLine(GoBack);
            if(GoBack == "true")
            {
                return RedirectToPage("../Index");
            }
            // if malicious post request request kids tickets on adult movie
            if((Booking.ChildTickets > 0) && (hideKidTickets)){ 
                Booking.AgeRestriction = 1;
            }
            else
            {
                Booking.AgeRestriction = 0;
            }
            //set Email of booking 
            if( ModelState.IsValid){
                db.Bookings.Add(Booking);
                db.SaveChanges();
                return RedirectToPage("../Remove/RemoveBookingCustomer/", new {ID = "confirmed"});  //ID confirmed trigger confirmation message in razor view
            }
            else
            {
                return RedirectToPage("../Remove/RemoveBookingCustomer/");
            }
        }
    }
}