using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Director
    {
        [Key]
        [Required()]
        public int DirectorID {get; set;}

        [MaxLength(20)]
        [Required()]
        public string DirectorName {get; set;}

        //many relation
        public ICollection<DirectorsMovieJunction> DirectorsMovieJunctions {set; get;}
    }
}