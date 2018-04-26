using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusOnlineReservationSystem.Models
{
    public class Lines
    {
        [Display(Name = "Line ID")]
        public string ID { get; set; }

        [Required]
        [Display(Name = "From")]
        public string FromCity { get; set; }

        [Required]
        [Display(Name = "To")]
        public string ToCity { get; set; }


        [Required]
        [Display(Name = "Price(LE)")]
        public double price { get; set; }

        [Required]
        [Display(Name = "Distance(KM)")]
        public double distance { get; set; }
    }
}