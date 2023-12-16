using Microsoft.EntityFrameworkCore.ChangeTracking;
using WebAPIDotnet8.Data;
using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Repository
{
    public class CovidADORepository : ICovidRespository
    {
        private readonly DALADO dal;

        public CovidADORepository()
        {
            dal = new DALADO();
        }

        public List<CovidLog> DeleteCovidLogs(int logID)
        {
            return dal.DeleteCovidLogs(logID);
        }

        public CovidLog GetCovid(int logID)
        {
            return dal.GetCovid(logID);
        }

        public List<CovidLog> GetcovidLogs()
        {

            return dal.GetcovidLogs();

        }

        public List<CovidLog> SaveCovidLogs(CovidLog covidLog)
        {
            return dal.SaveCovidLogs(covidLog);
        }

        public CovidLog UpdateCovidLogs(CovidLog covidLog)
        {
            return dal.UpdateCovidLogs(covidLog);
        }
    }
}
