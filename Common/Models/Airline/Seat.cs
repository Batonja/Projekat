using Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Common.Models.Airline
{
    public class Seat
    {
        public int SeatId { get; set; }

        [Required]
        public int SeatNumber { get; set; }
        
        public SeatState SeatState{ get;set;}

        
        public Flight Flight { get; set; }
    }
}
