using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class PossibleDiscountShowingJunction
    {
        [Key]
        [Required()]
        public int DiscountID {get;set;}

        [Required()]
        public int ShowingID {get;set;}

        //realted Entities singular realtions
        public Showing Showing {set;get;}
        public PossibleDiscount PossibleDiscount {set;get;}
    }
}