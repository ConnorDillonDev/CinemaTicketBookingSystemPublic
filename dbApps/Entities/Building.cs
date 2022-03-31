using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UWS.CinemaTicketBookingSystem
{
    public class Building 
    {

        //map columns
        [Key]
        [Required()]
        [MaxLength(40)]
        public string ComplexName {get; set;}

        [MaxLength(40)]
        [Required()]
        public string Street {get; set;}

        //Error Fixed; max length is attribute for string
        [Required()]
        public int StreetNum {get; set;}

        [MaxLength(20)]
        [Required()]
        public string PostCode {get; set;}

        [MaxLength(200)]
        [Required()]
        public string Address {get; set;}

        //realted Entities many realtion 
        public ICollection<Theatre> Theatres {set;get;}

        

    }
}