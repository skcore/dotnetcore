using WebAPIDotnet8.Entities;
using WebAPIDotnet8.Repository;

namespace WebAPIDotnet8.Services
{
    public class CovidLogEFService : ICovidLogDataService
    {
        private readonly ICovidRespository _covidRespository;

        public CovidLogEFService()
        {
            _covidRespository = new CovidEFRespository();
        }

        public List<CovidLog> DeleteCovidLogs(int logID)
        {
            var cvidlist= _covidRespository.DeleteCovidLogs(logID);

            return cvidlist;
        }

        public CovidLog GetCovid(int logID)
        {
            var covidLog=_covidRespository.GetCovid(logID);

            return covidLog;
        }

        public List<CovidLog> GetcovidLogs()
        {
            var covidlist = _covidRespository.GetcovidLogs();

            return covidlist;
        }

        public List<CovidLog> SaveCovidLogs(CovidLog covidLog)
        {
            var covidList = _covidRespository.SaveCovidLogs(covidLog);

            return covidList;
        }

        public CovidLog UpdateCovidLogs(CovidLog covidLog)
        {
           var covidlog=_covidRespository.UpdateCovidLogs(covidLog);

            return covidLog;
        }
    }
}
