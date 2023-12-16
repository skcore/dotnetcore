using Microsoft.EntityFrameworkCore;
using WebAPIDotnet8.Data;
using WebAPIDotnet8.Entities;

namespace WebAPIDotnet8.Repository
{
    public class CovidEFRespository : ICovidRespository
    {
        private readonly DataContext dataContext;

        public CovidEFRespository()
        {
        }

        public CovidEFRespository(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }
        public List<CovidLog> DeleteCovidLogs(int logID)
        {
            var covidlog= dataContext.covidLogs.Find(logID);
            dataContext.covidLogs.Remove(covidlog);
            dataContext.SaveChanges();

            return dataContext.covidLogs.ToList();
        }

        public CovidLog GetCovid(int logID)
        {
            return dataContext.covidLogs.Find(logID);
        }

        public List<CovidLog> GetcovidLogs()
        {
            return dataContext.covidLogs.ToList();
        }

        public List<CovidLog> SaveCovidLogs(CovidLog covidLog)
        {
            dataContext.covidLogs.Add(covidLog);
            dataContext.SaveChanges();

            return dataContext.covidLogs.ToList();
        }

        public CovidLog UpdateCovidLogs(CovidLog covidLogIP)
        {
            var covidlog= dataContext.covidLogs.Find(covidLogIP.Id);

            covidlog.Name = covidLogIP.Name;
            covidlog.Covidlogmsg = covidLogIP.Covidlogmsg;
            covidlog.CreatedDate = DateTime.Now;

            dataContext.SaveChanges();

            return covidlog;
        }
    }
}
