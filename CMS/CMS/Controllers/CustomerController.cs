using CMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CMSContext db = new CMSContext();
        [HttpPost]
        public IActionResult post(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpGet]
        public IEnumerable<Customer> get()
        {
            return db.Customers;
        }
        [HttpGet("{id}")]
        public Customer get(int id)
        {
            return db.Customers.FirstOrDefault(o => o.CustId == id);
        }

        [HttpPut]
        public IActionResult put(Customer customer)
        {
            db.Customers.Update(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var customer = db.Customers.Where(x => x.CustId == id).FirstOrDefault();
            db.Customers.Remove(customer);
            db.SaveChanges();
            return Ok(new { status = "your record is deleted suceessfully" });
        }
    }
}
