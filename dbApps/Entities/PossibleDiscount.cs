using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class PossibleDiscount
    {
        [Key]
        [Required()]
        public int DiscountID {get; set;}

        [MaxLength(8)]
        public string DiscountCode {get; set;}

        [MaxLength(20)]
        [Required()]
        public string DiscountOffer {get; set;}

        //many relation
        public ICollection<PossibleDiscountShowingJunction> PossibleDiscountShowingJunctions {get; set;}

    }
}