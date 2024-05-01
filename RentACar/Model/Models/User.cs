using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_Model.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public Role UserRole { get; set; }
    }

    // Enumeration for User Role
    public enum Role
    {
        Admin = 1,
        User = 2
    }
}
