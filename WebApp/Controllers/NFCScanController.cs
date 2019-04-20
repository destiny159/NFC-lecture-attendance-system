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

        // POST: api/Todo
        [HttpPost("[action]")]
        public async Task<ActionResult<NFCScan>> PostScan(NFCScan item)
        {
            _context.NFCScans.Add(item);
            await _context.SaveChangesAsync();
            //System.Diagnostics.Debug.WriteLine(item.ToString());

            return CreatedAtAction(nameof(GetScan), new { id = item.ScanID }, item);
        }   
    }
}