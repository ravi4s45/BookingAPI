using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeskAPI.Models
{
    public partial class login
    {
        [Key]
        public string? Email { get; set; }
        public string? Password { get; set; }
        
    }
}
