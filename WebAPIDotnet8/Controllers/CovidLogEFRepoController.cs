using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDotnet8.Data;
using WebAPIDotnet8.Entities;
using WebAPIDotnet8.Services;

namespace WebAPIDotnet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidLogEFRepoController : ControllerBase
    {
        private readonly ICovidLogDataService covidLogData;

        public CovidLogEFRepoController()
        {
            this.covidLogData = new CovidLogEFService();
        }

        [HttpGet]
        public async Task<ActionResult<List<CovidLog>>> GetCovidLogs()
        {

           var covidlogs= covidLogData.GetcovidLogs();
            return Ok(covidlogs);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CovidLog>>> GetCovidLog(int id)
        {

            var covidlogs = covidLogData.GetCovid(id);
            return Ok(covidlogs);
        }

        [HttpPost]
        public async Task<ActionResult<List<CovidLog>>> SaveCovidLogs(CovidLog covidip)
        {
            var covidlogs = covidLogData.SaveCovidLogs(covidip);
            return Ok(covidlogs);
        }

        [HttpPut]
        public async Task<ActionResult<List<CovidLog>>> UpdateCovidLogs(CovidLog covidip)
        {
            var covidlogs = covidLogData.UpdateCovidLogs(covidip);
            return Ok(covidlogs);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<CovidLog>>> DeleteCovidLogs(int id)
        {
            var covidlogs = covidLogData.DeleteCovidLogs(id);
            return Ok(covidlogs);
        }
    }
}
