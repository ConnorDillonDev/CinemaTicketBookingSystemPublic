using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Movie
    {
        [Key]
        [MaxLength(60)]
        [Required()]
        public string MovieName {get; set;}

        [Required()]
        public int RunTime {get; set;}

        public string Image {get; set;}

        [MaxLength(200)]
        [Required()]
        public string Description {get; set;}

        [Required()]
        public decimal AdultPrice {get; set;}

        public decimal ChildPrice {get; set;}

        [Required()]
        public int RatingID {get; set;}

        [Required()]
        public int GenreID {get; set;}

        //realted entites
        //singlar
        public Genre Genre {get; set;}
        public AgeRating AgeRating {get; set;}

        //many relations
        public ICollection<Showing> Showings {get; set;}
        public ICollection<DirectorsMovieJunction> DirectorsMovieJunctions {get; set;}
        public ICollection<ActorsMovieJunction> ActorsMovieJunctions {get; set;}
    }
}