using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusOnlineReservationSystem.Models
{
    public class BusOnlineReservationSystemContext : DbContext
    {
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Bus> Buses { get; set; }

    }
}