using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Genre
    {
        [Key]
        [Required()]
        public int GenreID {get; set;}

        [MaxLength(20)]
        [Required()]
        public string GenreName {get; set;}

        //rel entites many table
        public ICollection<Movie> Movies {get; set;}

    }
}