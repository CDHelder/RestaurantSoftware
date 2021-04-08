using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurant_Core
{
    public enum EatingTime
    {
        Dinner,
        Lunch
    }
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EatingTime DinnerOrLunch { get; set; }

        public int TableId { get; set; }

    }
}
