using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class AgeRating
    {
        [Key]
        [MaxLength(5)]
        [Required()]
        public int RatingID {get; set;}


        [MaxLength(5)]
        [Required()]
        public string Age {get; set;}

        //realted many entity
        public ICollection<Movie> Movies {get; set;}
    }
}