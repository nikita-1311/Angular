using CMS.Models;
using Microsoft.AspNetCore.Authorization;
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
    //[Authorize]
    public class OfficeController : ControllerBase
    {
        CMSContext db = new CMSContext();
        [HttpGet]
        public IEnumerable<Office> get()
        {
            return db.Offices;
        }
        [HttpPost]
        public IActionResult post(Office office)
        {
            db.Offices.Add(office);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Office office)
        {
            db.Offices.Update(office);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
    }
}
