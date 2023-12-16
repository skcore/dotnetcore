using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIDotnet8.Data;
using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CovidLogController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public CovidLogController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<CovidLog>>> GetCovidLogs()
        {

            var covids = await _dataContext.covidLogs.ToListAsync();
            return Ok(covids);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CovidLog>>> GetCovidLog(int id)
        {

            var covid = await _dataContext.covidLogs.Where(x => x.Id == id).ToListAsync();

            if (covid is null)
                return BadRequest("Covid log not found");
            else
                return Ok(covid);

        }

        [HttpPost]
        public async Task<ActionResult<List<CovidLog>>> SaveCovidLogs(CovidLog covid)
        {
            _dataContext.covidLogs.Add(covid);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.covidLogs.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<CovidLog>>> UpdateCovidLogs(CovidLog covidip)
        {
            var covid = await _dataContext.covidLogs.FindAsync(covidip.Id);

            if (covid is null)
                return BadRequest("Covid log not found");
            else
            {
                covid.Name = covidip.Name;
                covid.Covidlogmsg = covidip.Covidlogmsg;
                await _dataContext.SaveChangesAsync();

                return Ok(covid);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CovidLog>>> DeleteCovidLogs(int id)
        {
            var covid = await _dataContext.covidLogs.FindAsync(id);

            if (covid is null)
                return BadRequest("Covid log not found");
            else
            {
                _dataContext.covidLogs.Remove(covid);

                await _dataContext.SaveChangesAsync();

                return Ok(await _dataContext.covidLogs.ToListAsync());
            }
        }
    }
}
