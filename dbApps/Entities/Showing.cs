using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Showing
    {
        [Key]
        [Required()]
        public int ShowingID {get; set;} 

        [Required()]
        public int PreBookedAmount {get; set;} 

        public string Day {get; set;} 

        public float StartTime {get; set;}

        [Required()]
        public int RemainingSeats {get; set;} 

        public int ScreenNum {get; set;} //done
        
        [MaxLength(500)]
        [Required()]
        public string MovieName {get; set;} //done

        //relations
        //singular        
        public virtual Movie Movie {get; set;}
        public virtual Theatre Theatre {get; set;}
        //many
        public virtual ICollection<Booking> Bookings {get; set;}
        public virtual ICollection<PossibleDiscountShowingJunction> PossibleDiscountShowingJunctions {get; set;}
    }
}