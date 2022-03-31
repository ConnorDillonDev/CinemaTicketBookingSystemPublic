using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UWS.CinemaTicketBookingSystem
{
    public class Theatre
    {
        //map columns
        [Key]
        [MaxLength(700)]
        [Required()]
        public int ScreenNum { get; set; }
        
        [MaxLength(160)]
        [Required()]
        public string Capacity { get; set; }

        [MaxLength(40)]
        [Required()]
        public string ComplexName { get; set; }

        //related
        //singular
        public Building Building { get; set; }
        //many
        public ICollection<Showing> Showings { get; set; }
    }
}