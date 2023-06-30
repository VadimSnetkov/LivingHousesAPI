using LivingHousesApi.Models;

namespace LivingHousesApi.Data
{
    public static class Seed
    {
        public static void Initialize(ApiContext context)
        {
            // Checking if data is already in database
            if (context.Houses.Any() || context.Appartments.Any() || context.Residents.Any())
            {
                return;
            }

            // creating and adding seed data
            var houses = new List<House>
        {
            new House { Number = 1, Street = "Lomonosova", City = "Riga", Country = "Latvija", PostalCode = "LV-1019"},
            new House { Number = 2, Street = "Turgeneva", City = "Riga", Country = "Latvija", PostalCode = "LV-1050"}
        };

            var appartments = new List<Appartment>
        {
            new Appartment { Number = 50, StairCase = 5, RoomNumber = 3, InhabitantNumber = 2, FullArea = 100.5f, LivingArea = 80.5f },
            new Appartment { Number = 51, StairCase = 5, RoomNumber = 2, InhabitantNumber = 1, FullArea = 70.2f, LivingArea = 60.2f },
            new Appartment { Number = 20, StairCase = 2, RoomNumber = 2, InhabitantNumber = 1, FullArea = 65.2f, LivingArea = 55.2f },
            new Appartment { Number = 21, StairCase = 2, RoomNumber = 3, InhabitantNumber = 1, FullArea = 90.2f, LivingArea = 70.2f },
            new Appartment { Number = 22, StairCase = 2, RoomNumber = 2, InhabitantNumber = 1, FullArea = 70.2f, LivingArea = 52.2f }
        };

            var residents = new List<Resident>
        {
            new Resident { Name = "Sintija", Surname = "Ivanova", PersonalID = "04017649993", BirthDate = new DateTime(1976, 4, 1), TelephoneNumber = "+37120594785", EmailAddress = "sintija@gmail.com", IsOwner=false },
            new Resident { Name = "Janis", Surname = "Ivanovs", PersonalID = "02107649993", BirthDate = new DateTime(1976, 10, 2), TelephoneNumber = "+37128574659", EmailAddress = "ivanov@gmail.com", IsOwner=true },
            new Resident { Name = "Peteris", Surname = "Barkovs", PersonalID = "09116513748", BirthDate = new DateTime(1965, 11, 9), TelephoneNumber = "+37124736452", EmailAddress = "peteris@gmail.com", IsOwner=true },
            new Resident { Name = "Zane", Surname = "Dimante", PersonalID = "02058979993", BirthDate = new DateTime(1989, 5, 2), TelephoneNumber = "+37125674755", EmailAddress = "zane@gmail.com", IsOwner=true }
        };


            context.Houses.AddRange(houses);
            context.Appartments.AddRange(appartments);
            context.Residents.AddRange(residents);

            context.SaveChanges();
        }
    }

}
