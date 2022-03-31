using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class DirectorsMovieJunction
    {

        [Key]
        [Required()]
        public int DirectorID {get;set;}

        [Key]
        [Required()]
        public string MovieName {get;set;}

        //realted Entities singular 
        public Director Director {set;get;}
        public Movie Movie {set;get;}


    }
}