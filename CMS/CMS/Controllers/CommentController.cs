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
    public class CommentController : ControllerBase
    {
        CMSContext db = new CMSContext();
        [HttpGet]
        public IEnumerable<Comment> get()
        {
            return db.Comments;
        }
        [HttpPost]
        public IActionResult post(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return Ok(new { status = "your record is added suceessfully" });
        }
        [HttpPut]
        public IActionResult put(Comment comment)
        {
            db.Comments.Update(comment);
            db.SaveChanges();
            return Ok(new { status = "your record is updated suceessfully" });
        }
    }
}
