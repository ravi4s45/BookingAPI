using System;
using System.Collections.Generic;

namespace DeskAPI.Models
{
    public partial class MeetingRoom
    {
        public string? MeetingId { get; set; }
        public int Capacity { get; set; }
        public string Name { get; set; } = null!;
        public int FloorNumber { get; set; }
        public byte? Availability { get; set; }
        public byte? Projector { get; set; }
        public byte? WhiteBoard { get; set; }
    }
}
