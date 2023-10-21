using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    public class MembersController : BaseApiController
    {
   
        private readonly DataContext _context;
         
        public MembersController(DataContext context)
        {
            _context = context;
          
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Member>>> GetMembers() {

           try
           {
                
              return  Ok(await _context.Members.ToArrayAsync() ) ;

           }
           catch (Exception ex)
           {
                
               return BadRequest( StatusCode(StatusCodes.Status400BadRequest, ex.Message));
           }

        }
   


         [HttpGet("{id}")]
        public async Task<ActionResult<Member>> GetMember(int id) {

            return await _context.Members.FindAsync(id);
        }

    }
}