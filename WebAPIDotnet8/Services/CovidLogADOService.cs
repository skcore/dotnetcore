using WebAPIDotnet8.Data;
using WebAPIDotnet8.Entities;
using WebAPIDotnet8.Repository;

namespace WebAPIDotnet8.Services
{
    public class CovidLogADOService : ICovidLogDataService
    {
        private readonly ICovidRespository _covidRespository;

        public CovidLogADOService()
        {
            _covidRespository = new CovidADORepository();
        }

        public List<CovidLog> DeleteCovidLogs(int logID)
        {
           return  _covidRespository.DeleteCovidLogs(logID);
        }

        public CovidLog GetCovid(int logID)
        {
           return _covidRespository.GetCovid(logID);
        }

        public List<CovidLog> GetcovidLogs()
        {
          
            return _covidRespository.GetcovidLogs();

        }

        public List<CovidLog> SaveCovidLogs(CovidLog covidLog)
        {
           return _covidRespository.SaveCovidLogs(covidLog);
        }

        public CovidLog UpdateCovidLogs(CovidLog covidLog)
        {
            return _covidRespository.UpdateCovidLogs(covidLog);
        }
    }
}
