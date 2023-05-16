using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemoG.Models;

namespace WebApiDemoG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpGet("")]
        public List<ContactModel> Get()
        {
            return new List<ContactModel>
            {
                new ContactModel{Id=1,Firstname="Tural",Lastname="Eliyev",PAN="4169855878789955"},
                new ContactModel{Id=2,Firstname="Mike",Lastname="Sina",PAN="4169996678789955"},
            };
        }

        [HttpGet("First")]
        public ContactModel GetFirst()
        {
            return new ContactModel { Id = 1, Firstname = "Tural", Lastname = "Eliyev", PAN = "4169855878789955" };
        }
    }
}
