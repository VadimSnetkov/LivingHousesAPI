using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace LivingHousesApi.Models
{
    public class House
    {
        public int HouseID { get; set; }
        public int Number { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        //public ICollection<Appartment> Appartments { get; set; }
        //public House()
        //{
        //    Appartments = new List<Appartment>();
        //}
    }
}