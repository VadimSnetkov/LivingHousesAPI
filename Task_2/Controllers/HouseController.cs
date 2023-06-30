using LivingHousesApi.Data;
using LivingHousesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivingHousesApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly ApiContext _context;
        public HouseController(ApiContext context)
        {
            _context = context;
        }

        //Create/Edit

        [HttpPost]
        public JsonResult CreateEdit(House houses)
        {
            if (houses.HouseID == 0)
            {
                _context.Houses.Add(houses);
            }
            else
            {
                var houseInDb = _context.Houses.Find(houses.HouseID);
                if (houseInDb == null)
                    return new JsonResult(NotFound());

                houseInDb = houses;
            }
                _context.SaveChanges();

                return new JsonResult(Ok(houses));
        }

        //Get

        [HttpGet]
        public JsonResult Get(int HouseID)
        {
            var result = _context.Houses.Find(HouseID);

            if(result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        //Delete

        [HttpDelete]
        public JsonResult Delete(int HouseID)
        {
            var result = _context.Houses.Find(HouseID);

            if(result == null)
                return new JsonResult(NotFound());

            _context.Houses.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        //Get all

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Houses.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
