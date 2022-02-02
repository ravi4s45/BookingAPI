using DeskAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
namespace Booking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController : ControllerBase
    {

       
        [HttpGet]
        public IEnumerable<UserDetail> Get()
        {
            using (var context = new ProfilesDBContext())
            {
                return context.UserDetails.ToList();
            }

        }
        [HttpPost] // /Register post
        public async Task<ActionResult<UserDetail>> Post(UserDetail user)
        {
            using (var context = new ProfilesDBContext())
            {
                context.UserDetails.Add(user);
                await context.SaveChangesAsync();
                return Ok(); //200 success
            }
            return BadRequest();

        }
        // /Register/login
        [Route("login")]
        [HttpPost]
        public async Task<ActionResult<UserDetail>> Login(login userlogin)
        {
            using (var context = new ProfilesDBContext())
            {
                login newUser = userlogin;
                var Person = context.UserDetails.Where(x => x.Email.Equals(userlogin.Email) && x.Password.Equals(userlogin.Password)).FirstOrDefault();

                await context.SaveChangesAsync();
                if (Person == null)
                {
                    return NotFound();
                }
                
                return Person;
            }

        }
    }
}