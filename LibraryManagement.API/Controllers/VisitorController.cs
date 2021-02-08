using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/visitor")]
    [ApiController]
    public class VisitorController : ControllerBase
    {
        [HttpPost("register")]
        public int Register(Visitor visitor)
        {
            return 0;
        }

        [HttpPut("{visitorId}/book/{bookId}/request")]
        public bool RequestBook(int visitorId, int bookId)
        {
            return true;
        }

        [HttpPut("{visitorId}/book/{bookId}/return")]
        public bool ReturnBook(int visitorId, int bookId)
        {
            return true;
        }

        [HttpPut("{visitorCode}/clockin")]
        public bool LibraryClockIn(string visitorCode)
        {
            return true;
        }

        [HttpPut("{visitorCode}/clockout")]
        public bool LibraryClockOut(string visitorCode)
        {
            return true;
        }
    }
}