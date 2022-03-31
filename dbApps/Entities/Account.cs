using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Account
    {
        //map columns
        //primary key
        [Key]
        //cannot be null
        [Required()]
        //max length
        [MaxLength(30)]
        public string Email {get; set;}


        [MaxLength(12)]
        [Required()]
        public string Username {get; set;}

        [MaxLength(60)]
        public string PasswordHash {get; set;}

        [MaxLength(60)]
        public string PasswordSalt {get; set;}
        
        [MaxLength(30)]
        [Required()]
        public string FirstName {get; set;}

        [MaxLength(30)]
        [Required()]
        public string LastName {get; set;}

        [MaxLength(61)]
        public string FullName {get; set;}

        [Required()]
        public int IsStaff {get; set;}

        //realted Entities
        public ICollection<Booking> Bookings {set;get;}
    }
}