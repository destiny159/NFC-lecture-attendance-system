using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFCSystem.Models;
using NFCSystem.Data;
using Microsoft.AspNetCore.Mvc;

namespace NFCSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NFCScanController : ControllerBase
    {
        private readonly NFCScanContext _context;

        public NFCScanController(NFCScanContext context)
        {
            _context = context;

            if (_context.NFCScans.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.NFCScans.Add(new NFCScan { UID = 454655656, TimeStamp = 546785754655 });
                _context.NFCScans.Add(new NFCScan { UID = 454655656, TimeStamp = 5 });
                _context.NFCScans.Add(new NFCScan { UID = 454655656, TimeStamp = 54678555754655 });
                _context.NFCScans.Add(new NFCScan { UID = 454655656, TimeStamp = 54678555754654 });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<NFCScan>>> GetScans()
        {
            return await _context.NFCScans.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<NFCScan>> GetScan(long id)
        {
        var todoItem = await _context.NFCScans.FindAsync(id);

        if (todoItem == null)
        {
            return NotFound();
        }

        return todoItem;
        }   
    }
}