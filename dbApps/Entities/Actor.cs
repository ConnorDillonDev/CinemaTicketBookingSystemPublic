using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Actor
    {
        //primary key 
        [Key]
        [Required()]
        public int ActorID {get; set;}

        [MaxLength(20)]
        [Required()]
        public string ActorName {get; set;}

        //related many table
        public ICollection<ActorsMovieJunction> ActorsMovieJunctions {get; set;}


    }
}