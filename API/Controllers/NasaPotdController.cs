using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NasaPotdController : ControllerBase
    {
        private readonly DataContext _context;

        public NasaPotdController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<NasaPotd>>> Get(){
            var nasaPotds = await _context.NasaPotds.ToListAsync();
            return nasaPotds;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NasaPotd>> Get(int id)
        {
            var nasaPotds = await _context.NasaPotds.ToListAsync();
            var nasaPotd = nasaPotds.FirstOrDefault(p => p.Id == id);
            return nasaPotd;
        }

        [HttpPost]
        public async Task<ActionResult<List<NasaPotd>>> AddPotd(NasaPotd newPotd){
            _context.NasaPotds.Add(newPotd);
            await _context.SaveChangesAsync();
        
            var nasaPotds = await _context.NasaPotds.ToListAsync();
            return nasaPotds;
        }

        [HttpPost]
        [Route("AddAll")]
        public async Task<ActionResult<List<NasaPotd>>> AddAllPotd(NasaPotd[] newPotd)
        {
            await _context.NasaPotds.AddRangeAsync(newPotd);
            await _context.SaveChangesAsync();

            var nasaPotds = await _context.NasaPotds.ToListAsync();
            return nasaPotds;
        }



    }
}