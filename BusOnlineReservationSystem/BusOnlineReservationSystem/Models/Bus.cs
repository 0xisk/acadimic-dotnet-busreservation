using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusOnlineReservationSystem.Models
{
    public class Bus
    {
        [Display(Name = "Bus ID")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Number of Chairs")]
        public int NumOfChairs { get; set; }

        [Required]
        [Display(Name = "Bus Color")]
        public string color { get; set; }


        public Line line { get; set; }
        [Required]
        [Display(Name = "Line ID")]
        public string lineID { get; set; }
    }
}