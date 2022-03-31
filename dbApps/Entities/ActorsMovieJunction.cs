using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class ActorsMovieJunction
    {
        [Key]
        [Required()]
        public int ActorID {get;set;}

        [Key]
        [Required()]
        public string MovieName {get;set;}

        //realted Entities singular relations
        public Actor Actor {set;get;}
        public Movie Movie {set;get;}
    }
}