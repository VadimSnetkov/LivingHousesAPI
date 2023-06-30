using Microsoft.EntityFrameworkCore;
using AutoMapper;
using LivingHousesApi.Models;
using System.Diagnostics.Metrics;

namespace LivingHousesApi.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<House> Houses { get; set; }
        public DbSet<Appartment> Appartments { get; set; }
        public DbSet<Resident> Residents { get; set; }
        //public DbSet<ResidentAppartment> ResidentAppartments { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<House>()
        //        .HasMany(p => p.Appartments)
        //        .WithOne(c => c.House)
        //    .IsRequired();

        //    modelBuilder.Entity<Appartment>()
        //        .HasMany(s => s.Residents)
        //        .WithMany(s => s.Appartments);
        //    modelBuilder.Entity<Resident>()
        //        .HasMany(s => s.Appartments)
        //        .WithMany(s => s.Residents);
        //}
    }
    
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Appartment, Appartment>()
                .ForMember(dest => dest.AppartmentID, opt => opt.Ignore());
        }
    }
}
