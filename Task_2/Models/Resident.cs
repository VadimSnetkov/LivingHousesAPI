using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivingHousesApi.Models
{
    public class Resident
    {
        public int ResidentID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? PersonalID { get; set; }
        public DateTime BirthDate { get; set; }
        public string? TelephoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public bool IsOwner { get; set; }
        //public ICollection<ResidentAppartment> ResidentAppartments { get; set; }
        //public ICollection<Appartment> Appartments { get; set; }
        
    }
}