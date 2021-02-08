using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.API.Controllers
{
    [Route("api/librarian")]
    [ApiController]
    public class LibrarianController : ControllerBase
    {
        [HttpPut("book/{bookId}/issue/visitor/{visitorId}")]
        public bool IssueBook(int bookId, int visitorId)
        {
            return true;
        }

        [HttpPut("book/{bookId}/withdraw")]
        public bool WithdrawBook(int bookId)
        {
            return true;
        }
    }
}