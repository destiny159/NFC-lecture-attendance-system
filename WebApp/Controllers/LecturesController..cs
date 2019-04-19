using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NFCSystem.Models;

namespace NFCSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<List<Lecture>> Get(int id)
        {
            List<Lecture> lectures = new List<Lecture>()
            {
                new Lecture()
                {
                    StudentId = 1,
                    Title = "Programų sistemų inžinerija",
                    Details = "09:00 - 10:30<br>P175B015 Programų sistemų inžinerija<br>Teorinė paskaita<br>Kaunas, Studentų g.50 XI r.-101<br>Dėstytojas: Tomas Blažauskas",
                    Start = Convert.ToDateTime("2019-04-17 09:00"),
                    Finish = Convert.ToDateTime("2019-04-17 10:30"),
                    Open = false
                },
                new Lecture()
                {
                    StudentId = 1,
                    Title = "Programų sistemų inžinerija",
                    Details = "09:00 - 10:30<br>P175B015 Programų sistemų inžinerija<br>Praktinė paskaita<br>Kaunas, Studentų g.50 XI r.-101<br>Dėstytojas: Tomas Blažauskas",
                    Start = Convert.ToDateTime("2019-04-01 09:00"),
                    Finish = Convert.ToDateTime("2019-04-01 10:30"),
                    Open = false
                },
                new Lecture()
                {
                    StudentId = 1,
                    Title = "Programų sistemų inžinerija",
                    Details = "09:00 - 10:30<br>P175B015 Programų sistemų inžinerija<br>Laboratorinis darbas<br>Kaunas, Studentų g.50 XI r.-101<br>Dėstytojas: Tomas Blažauskas",
                    Start = Convert.ToDateTime("2019-04-23 09:00"),
                    Finish = Convert.ToDateTime("2019-04-23 10:30"),
                    Open = false
                }
            };
            return lectures.Where(x => x.StudentId == id).ToList();
        }
    }
}
