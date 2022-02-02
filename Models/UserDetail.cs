using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeskAPI.Models
{
    public partial class UserDetail
    {
        [Key]
        public string? UserId { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Designation { get; set; }
        public string? Email { get; set; }
    }
}
