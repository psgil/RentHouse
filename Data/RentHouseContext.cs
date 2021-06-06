using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentHouse.Models;

namespace RentHouse.Data
{
    public class RentHouseContext : DbContext
    {
        public RentHouseContext (DbContextOptions<RentHouseContext> options)
            : base(options)
        {
        }

        public DbSet<RentHouse.Models.House> House { get; set; }

        public DbSet<RentHouse.Models.Booking> Booking { get; set; }

        public DbSet<RentHouse.Models.familyDetail> familyDetail { get; set; }

        public DbSet<RentHouse.Models.Register> Register { get; set; }
    }
}
