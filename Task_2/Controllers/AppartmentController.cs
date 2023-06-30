using LivingHousesApi.Data;
using LivingHousesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivingHousesApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AppartmentController : ControllerBase
    {
        private readonly ApiContext _context;
        public AppartmentController(ApiContext context)
        {
            _context = context;
        }


        //Create/Edit

        [HttpPost]

        public JsonResult CreateEdit(Appartment appartments)
        {
            if (appartments.AppartmentID == 0)
            {
                _context.Appartments.Add(appartments);
            }
            else
            {
                var appartmentInDb = _context.Appartments.Find(appartments.AppartmentID);
                if (appartmentInDb == null)
                    return new JsonResult(NotFound());

                appartmentInDb = appartments;
            }
            _context.SaveChanges();

            return new JsonResult(Ok(appartments));
        }

        //Get

        [HttpGet]
        public JsonResult Get(int AppartmentID)
        {
            var result = _context.Appartments.Find(AppartmentID);
            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        //Delete

        [HttpDelete]
        public JsonResult Delete(int AppartmentID)
        {
            var result = _context.Appartments.Find(AppartmentID);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Appartments.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        //Get all

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Appartments.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
