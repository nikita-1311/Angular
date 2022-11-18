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
    public class ContactController : ControllerBase
    {
        CMSContext db = new CMSContext();
        [HttpPost]
        public IActionResult post(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpGet]
        public IEnumerable<Contact> get()
        {
            return db.Contacts;
        }
    }
}
