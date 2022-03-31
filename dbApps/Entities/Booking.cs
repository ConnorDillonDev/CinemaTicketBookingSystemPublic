using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Booking
    {
        [Key]
        [Required()]
        public int BookingID {get; set;}

        public int NumberInBooking {get; set;}

        public int AdultTickets {get; set;}
        
        public int ChildTickets {get; set;}

        [Required()]
        public int AgeRestriction {get; set;}

        [Required()]
        public float TotalPrice {get; set;}

        [MaxLength(8)]
        public string SuppliedDiscountCode {get; set;}


        [Required()]
        public int ShowingID {get; set;}

        [Required()]
        public string Email {get; set;}

        //realted entties singular realtions
        public Account Account {get; set;}
        public Showing Showing {get; set;}
    }
}