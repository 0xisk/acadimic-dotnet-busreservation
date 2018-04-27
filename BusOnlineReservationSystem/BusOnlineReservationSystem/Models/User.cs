using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusOnlineReservationSystem.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "username")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }
    }
}