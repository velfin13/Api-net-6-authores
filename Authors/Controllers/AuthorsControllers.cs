using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApiAuthors.Entities;

namespace WebApiAuthors.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsControllers : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public AuthorsControllers(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Author>>> Get() 
        {
            return await context.Authors.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult> Post(Author author)
        {
            context.Add(author);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}

   
