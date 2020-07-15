using ComedyEvents.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComedyEvents.Context
{
    public class EventContext :DbContext
    {

        private readonly IConfiguration _configuration;
        public EventContext(DbContextOptions options, IConfiguration configration) : base(options)
        {
            _configuration = configration;
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<Comedian> Comedians { get; set; }
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Venue> Venues { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ComedyEvent"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Event>()
                .HasData(new
                {
                    EventId = 1,
                    EventName = "Funny Comedy Night",
                    EventDate = new DateTime(2019, 05, 19),
                    VenueId = 1
                });

            builder.Entity<Venue>()
                .HasData(new
                {
                    VenueId = 1,
                    VenueName = "Mumbai",
                    Street = "Andheri",
                    City = "Mumbai",
                    State = "MH",
                    ZipCode = "400100",
                    Seating = 001,
                    ServesAlcohol = false
                });

            builder.Entity<Gig>()
                .HasData(new
                {
                    GigId = 1,
                    EventId = 1,
                    ComedianId = 1,
                    GigHeadline = "Zakir Khan",
                    GigLengthInMinutes = 40
                }, new
                {
                    GigId = 2,
                    EventId = 1,
                    ComedianId = 2,
                    GigHeadline = "Kapil Sharma",
                    GigLengthInMinutes = 55
                });

            builder.Entity<Comedian>()
                .HasData(new
                {
                    ComedianId = 1,
                    FirstName = "Sunil",
                    LastName = "Grover",
                    ContactPhone = "114567890"
                }, new
                {
                    ComedianId = 2,
                    FirstName = "Zakir",
                    LastName = "Khan",
                    ContactPhone = "123456788"
                });
        }
    }
}
