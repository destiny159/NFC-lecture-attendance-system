using System.Security.Cryptography.X509Certificates;
using System.Net;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NFCSystem.Models;
using NFCSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace NFCSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NFCScanController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NFCScanController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Todo
        [HttpGet("[action]")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<NFCScan>>> GetScans()
        {
            return await _context.NFCScans.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("[action]/{id}")]
        public async Task<ActionResult<NFCScan>> GetScan(long id)
        {
        var todoItem = await _context.NFCScans.FindAsync(id);
        var student = await _context.Users.FirstOrDefaultAsync(x => x.UID == todoItem.UID);
        var restult = new {scan = todoItem, stud = student};
        if (todoItem == null)
        {
            return NotFound();
        }

        return Ok(restult);
        }

        // POST: api/Todo
        
        [HttpPost("[action]")]
        //[AllowAnonymous]
        public async Task<ActionResult<NFCScan>> PostScan(NFCScan item)
        {       
            _context.NFCScans.Add(item);
            await _context.SaveChangesAsync();
            //System.Diagnostics.Debug.WriteLine(item.ToString());

            return CreatedAtAction(nameof(GetScan), new { id = item.ScanID }, item);
        }   
    }
}