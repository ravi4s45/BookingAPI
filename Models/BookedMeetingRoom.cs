using System;
using System.Collections.Generic;

namespace DeskAPI.Models
{
    public partial class BookedMeetingRoom
    {
        public string? MeetingBookingId { get; set; }
        public string RoomId { get; set; } = null!;
        public string EmployeeId { get; set; } = null!;
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int FloorNumber { get; set; }
        public byte? CheckIn { get; set; }
    }
}
