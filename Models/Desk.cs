using System;
using System.Collections.Generic;

namespace DeskAPI.Models
{
    public partial class Desk
    {
        public string? DeskId { get; set; }
        public byte? Availability { get; set; }
        public int? FloorNumber { get; set; }
        public byte? Pc { get; set; }
    }
}
