using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivingHousesApi.Models
{
    public class Appartment
    {
        public int AppartmentID { get; set; }
        public int Number { get; set; }
        public float StairCase { get; set; }
        public int RoomNumber { get; set; }
        public int InhabitantNumber { get; set; }
        public float FullArea { get; set; }
        public float LivingArea { get; set; }
        //public int HouseID { get; set; }
        //public House? House { get; set; }
        //public ICollection<ResidentAppartment> ResidentAppartments { get; set; } 
        //public ICollection<Resident> Residents { get; set; }
    }
}
