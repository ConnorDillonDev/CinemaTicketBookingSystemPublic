//link to index page - serverside code - runs when requested by client
using System.Collections;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using UWS.CinemaTicketBookingSystem;
using System.Linq;
using System;
using Microsoft.AspNetCore.Mvc;
using UWS.CinemaTicketBookingSystem;


namespace WebApp.Pages
{
    public class BookingModel : PageModel
    {
        public string Heading1 {get;set;}

        public IList<Booking> Bookings {get;set;}

        private Cinema db;

        public BookingModel(Cinema injectedContext)
        {   
            db = injectedContext;
        }   

        public void OnGet(){
            //set property on page request
            Heading1 = "Bookings";

            Bookings = db.Bookings.ToList();

            // Movies = db.Movies.ToList();
            //Bookings = new[] {"complex1", "complex2", "complex3"};
            // Cinema db = new Cinema(); // create an instance of the database to reference 
            // Bookings = db.Bookings.Select(Booking => Booking.ComplexName.ToString()); //iterate over instances of Booking in the database
        }

        [BindProperty]
        public Booking Booking { get; set; }

        // public IActionResult OnPost()
        // {
        //     if (ModelState.IsValid)
        //     {
        //         db.Movies.Add(Movie);
        //         db.SaveChanges();
        //         return RedirectToPage("/");
        //     }
        //     return Page();
        // }
    }
}