using System;
using System.Collections.Generic;

namespace DeskAPI.Models
{
    public partial class BookedDesk
    {
        public string? DeskBookingId { get; set; }
        public string DeskId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime Date { get; set; }
        public string Timeslot { get; set; } = null!;
        public int FloorNumber { get; set; }
        public byte? CheckIn { get; set; }
    }
}
