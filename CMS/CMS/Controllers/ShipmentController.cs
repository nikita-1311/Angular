using CMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        CMSContext db = new CMSContext();
        [HttpGet]
        public IEnumerable<Shipment> get()
        {
            return db.Shipments;
        }
        [HttpPost]
        public IActionResult post(Shipment shipment)
        {
            db.Shipments.Add(shipment);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Shipment shipment)
        {
            db.Shipments.Update(shipment);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var shipment = db.Shipments.Where(x => x.SId == id).FirstOrDefault();
            db.Shipments.Remove(shipment);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
