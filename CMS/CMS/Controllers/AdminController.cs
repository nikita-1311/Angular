using CMS.Models;
using CMS.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        CMSContext db;
        private IConfiguration config;
        public AdminController(CMSContext _db, IConfiguration _config)
        {
            db = _db;
            config = _config;
        }
        [HttpPost("loginUser")]
        public IActionResult Admin(AdminViewModel adminViewModel)
        {

            var Islogin = db.Admins.Any(x => x.Name == adminViewModel.UserName && x.Password == adminViewModel.Password);
            var token = GenerateToken(adminViewModel);
            return Ok(new { IsLogin = Islogin, Token = token, Message = Islogin ? "Successfully login" : "Either username or password is incorrect" });
        }
        private string GenerateToken(AdminViewModel loginViewModel)
        {
            var key = config["jwt:Key"];
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            var token = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, loginViewModel.UserName),
                    new Claim(ClaimTypes.Name,loginViewModel.Password)
                }),
                Expires = DateTime.Now.AddMinutes(120),
                SigningCredentials = credentials
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenjson = tokenHandler.CreateToken(token);
            return tokenHandler.WriteToken(tokenjson);
        }
    }
}