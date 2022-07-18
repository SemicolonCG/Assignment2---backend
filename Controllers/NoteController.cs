using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {

        private readonly DataContext _dataContext;

        public NoteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        // GET: api/<Note1Controller>
        [HttpGet]
        public ActionResult<IEnumerable<Note>> Get()
        {
            var notes = _dataContext.Notes
                .Include(y => y.Comment)
                .Include(y => y.Replies)
                .AsNoTracking()
                .ToList();
            return notes;
        }

        // GET api/<Note1Controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<Note1Controller>
        [HttpPost]
        public ActionResult<string> Post(Note note)
        {
            var res = _dataContext.Notes.Add(note);
            _dataContext.SaveChanges();

            if (res != null)
            {
                return "success";
            }
            else
            {

                return "fail";
            }
        }

        // PUT api/<Note1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Note1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
