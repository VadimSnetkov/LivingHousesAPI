using LivingHousesApi.Data;
using LivingHousesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivingHousesApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ResidentController : ControllerBase
    {
        private readonly ApiContext _context;
        public ResidentController(ApiContext context)
        {
            _context = context;
        }

        //Create/Edit

        [HttpPost]
        public JsonResult CreateEdit(Resident residents)
        {
            if (residents.ResidentID == 0)
            {
                _context.Residents.Add(residents);
            }
            else
            {
                var residentInDb = _context.Residents.Find(residents.ResidentID);
                if (residentInDb == null)
                    return new JsonResult(NotFound());

                residentInDb = residents;
            }
            _context.SaveChanges();

            return new JsonResult(Ok(residents));
        }

        //Get

        [HttpGet]
        public JsonResult Get(int ResidentID)
        {
            var result = _context.Residents.Find(ResidentID);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        //Delete

        [HttpDelete]
        public JsonResult Delete(int ResidentID)
        {
            var result = _context.Residents.Find(ResidentID);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Residents.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        //Get all

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Residents.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
